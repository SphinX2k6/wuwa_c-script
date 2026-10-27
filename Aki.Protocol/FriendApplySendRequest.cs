using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000650 RID: 1616
	[NetMessage(EMessageId.FriendApplySendRequest)]
	public sealed class FriendApplySendRequest : IMessage<FriendApplySendRequest>, IMessage, IEquatable<FriendApplySendRequest>, IDeepCloneable<FriendApplySendRequest>, IBufferMessage
	{
		// Token: 0x06009498 RID: 38040 RVA: 0x00167104 File Offset: 0x00165304
		[NullableContext(1)]
		public static FriendApplySendRequest Create()
		{
			return new FriendApplySendRequest();
		}

		// Token: 0x17001D94 RID: 7572
		// (get) Token: 0x06009499 RID: 38041 RVA: 0x0016710B File Offset: 0x0016530B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D95 RID: 7573
		// (get) Token: 0x0600949A RID: 38042 RVA: 0x0016710E File Offset: 0x0016530E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendApplySendRequest.Descriptor;
			}
		}

		// Token: 0x0600949B RID: 38043 RVA: 0x00167115 File Offset: 0x00165315
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplySendRequest()
		{
		}

		// Token: 0x0600949C RID: 38044 RVA: 0x0016711D File Offset: 0x0016531D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplySendRequest(FriendApplySendRequest other) : this()
		{
			this.id_ = other.id_;
			this.way_ = other.way_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600949D RID: 38045 RVA: 0x0016714E File Offset: 0x0016534E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplySendRequest Clone()
		{
			return new FriendApplySendRequest(this);
		}

		// Token: 0x17001D96 RID: 7574
		// (get) Token: 0x0600949E RID: 38046 RVA: 0x00167156 File Offset: 0x00165356
		// (set) Token: 0x0600949F RID: 38047 RVA: 0x0016715E File Offset: 0x0016535E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17001D97 RID: 7575
		// (get) Token: 0x060094A0 RID: 38048 RVA: 0x00167167 File Offset: 0x00165367
		// (set) Token: 0x060094A1 RID: 38049 RVA: 0x0016716F File Offset: 0x0016536F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplyWay Way
		{
			get
			{
				return this.way_;
			}
			set
			{
				this.way_ = value;
			}
		}

		// Token: 0x060094A2 RID: 38050 RVA: 0x00167178 File Offset: 0x00165378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendApplySendRequest);
		}

		// Token: 0x060094A3 RID: 38051 RVA: 0x00167186 File Offset: 0x00165386
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendApplySendRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Way == other.Way && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060094A4 RID: 38052 RVA: 0x001671C4 File Offset: 0x001653C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Way != FriendApplyWay.Search)
			{
				num ^= this.Way.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060094A5 RID: 38053 RVA: 0x00167222 File Offset: 0x00165422
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060094A6 RID: 38054 RVA: 0x0016722F File Offset: 0x0016542F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060094A7 RID: 38055 RVA: 0x00167238 File Offset: 0x00165438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Way != FriendApplyWay.Search)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.Way);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060094A8 RID: 38056 RVA: 0x00167294 File Offset: 0x00165494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Way != FriendApplyWay.Search)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Way);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060094A9 RID: 38057 RVA: 0x001672EC File Offset: 0x001654EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendApplySendRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Way != FriendApplyWay.Search)
			{
				this.Way = other.Way;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060094AA RID: 38058 RVA: 0x0016733C File Offset: 0x0016553C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060094AB RID: 38059 RVA: 0x00167348 File Offset: 0x00165548
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
				if (num != 48U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.Way = (FriendApplyWay)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004731 RID: 18225
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004732 RID: 18226
		public const int IdFieldNumber = 10;

		// Token: 0x04004733 RID: 18227
		private int id_;

		// Token: 0x04004734 RID: 18228
		public const int WayFieldNumber = 6;

		// Token: 0x04004735 RID: 18229
		private FriendApplyWay way_;
	}
}
