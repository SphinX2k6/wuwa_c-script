using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013B2 RID: 5042
	[NetMessage(EMessageId.TeleportToTargetRequest)]
	public sealed class TeleportToTargetRequest : IMessage<TeleportToTargetRequest>, IMessage, IEquatable<TeleportToTargetRequest>, IDeepCloneable<TeleportToTargetRequest>, IBufferMessage
	{
		// Token: 0x0601AD50 RID: 109904 RVA: 0x003E83F7 File Offset: 0x003E65F7
		[NullableContext(1)]
		public static TeleportToTargetRequest Create()
		{
			return new TeleportToTargetRequest();
		}

		// Token: 0x17005AD9 RID: 23257
		// (get) Token: 0x0601AD51 RID: 109905 RVA: 0x003E83FE File Offset: 0x003E65FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005ADA RID: 23258
		// (get) Token: 0x0601AD52 RID: 109906 RVA: 0x003E8401 File Offset: 0x003E6601
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportToTargetRequest.Descriptor;
			}
		}

		// Token: 0x0601AD53 RID: 109907 RVA: 0x003E8408 File Offset: 0x003E6608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportToTargetRequest()
		{
		}

		// Token: 0x0601AD54 RID: 109908 RVA: 0x003E8410 File Offset: 0x003E6610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportToTargetRequest(TeleportToTargetRequest other) : this()
		{
			this.temporaryTeleportId_ = other.temporaryTeleportId_;
			this.rot_ = ((other.rot_ != null) ? other.rot_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AD55 RID: 109909 RVA: 0x003E845C File Offset: 0x003E665C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportToTargetRequest Clone()
		{
			return new TeleportToTargetRequest(this);
		}

		// Token: 0x17005ADB RID: 23259
		// (get) Token: 0x0601AD56 RID: 109910 RVA: 0x003E8464 File Offset: 0x003E6664
		// (set) Token: 0x0601AD57 RID: 109911 RVA: 0x003E846C File Offset: 0x003E666C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TemporaryTeleportId
		{
			get
			{
				return this.temporaryTeleportId_;
			}
			set
			{
				this.temporaryTeleportId_ = value;
			}
		}

		// Token: 0x17005ADC RID: 23260
		// (get) Token: 0x0601AD58 RID: 109912 RVA: 0x003E8475 File Offset: 0x003E6675
		// (set) Token: 0x0601AD59 RID: 109913 RVA: 0x003E847D File Offset: 0x003E667D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Rotator Rot
		{
			get
			{
				return this.rot_;
			}
			set
			{
				this.rot_ = value;
			}
		}

		// Token: 0x0601AD5A RID: 109914 RVA: 0x003E8486 File Offset: 0x003E6686
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportToTargetRequest);
		}

		// Token: 0x0601AD5B RID: 109915 RVA: 0x003E8494 File Offset: 0x003E6694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportToTargetRequest other)
		{
			return other != null && (other == this || (this.TemporaryTeleportId == other.TemporaryTeleportId && object.Equals(this.Rot, other.Rot) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AD5C RID: 109916 RVA: 0x003E84E4 File Offset: 0x003E66E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TemporaryTeleportId != 0L)
			{
				num ^= this.TemporaryTeleportId.GetHashCode();
			}
			if (this.rot_ != null)
			{
				num ^= this.Rot.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AD5D RID: 109917 RVA: 0x003E8539 File Offset: 0x003E6739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AD5E RID: 109918 RVA: 0x003E8546 File Offset: 0x003E6746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AD5F RID: 109919 RVA: 0x003E8550 File Offset: 0x003E6750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rot_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Rot);
			}
			if (this.TemporaryTeleportId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.TemporaryTeleportId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AD60 RID: 109920 RVA: 0x003E85AC File Offset: 0x003E67AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TemporaryTeleportId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TemporaryTeleportId);
			}
			if (this.rot_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rot);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AD61 RID: 109921 RVA: 0x003E8604 File Offset: 0x003E6804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeleportToTargetRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TemporaryTeleportId != 0L)
			{
				this.TemporaryTeleportId = other.TemporaryTeleportId;
			}
			if (other.rot_ != null)
			{
				if (this.rot_ == null)
				{
					this.Rot = new Rotator();
				}
				this.Rot.MergeFrom(other.Rot);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AD62 RID: 109922 RVA: 0x003E866C File Offset: 0x003E686C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AD63 RID: 109923 RVA: 0x003E8678 File Offset: 0x003E6878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 10U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TemporaryTeleportId = input.ReadInt64();
					}
				}
				else
				{
					if (this.rot_ == null)
					{
						this.Rot = new Rotator();
					}
					input.ReadMessage(this.Rot);
				}
			}
		}

		// Token: 0x04009CF4 RID: 40180
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009CF5 RID: 40181
		public const int TemporaryTeleportIdFieldNumber = 11;

		// Token: 0x04009CF6 RID: 40182
		private long temporaryTeleportId_;

		// Token: 0x04009CF7 RID: 40183
		public const int RotFieldNumber = 1;

		// Token: 0x04009CF8 RID: 40184
		private Rotator rot_;
	}
}
