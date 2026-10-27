using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CD6 RID: 3286
	[NetMessage(EMessageId.PhantomIdentifyResponse)]
	public sealed class PhantomIdentifyResponse : IMessage<PhantomIdentifyResponse>, IMessage, IEquatable<PhantomIdentifyResponse>, IDeepCloneable<PhantomIdentifyResponse>, IBufferMessage
	{
		// Token: 0x06011C8D RID: 72845 RVA: 0x0029A264 File Offset: 0x00298464
		[NullableContext(1)]
		public static PhantomIdentifyResponse Create()
		{
			return new PhantomIdentifyResponse();
		}

		// Token: 0x17003AED RID: 15085
		// (get) Token: 0x06011C8E RID: 72846 RVA: 0x0029A26B File Offset: 0x0029846B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AEE RID: 15086
		// (get) Token: 0x06011C8F RID: 72847 RVA: 0x0029A26E File Offset: 0x0029846E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomIdentifyResponse.Descriptor;
			}
		}

		// Token: 0x06011C90 RID: 72848 RVA: 0x0029A275 File Offset: 0x00298475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomIdentifyResponse()
		{
		}

		// Token: 0x06011C91 RID: 72849 RVA: 0x0029A280 File Offset: 0x00298480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomIdentifyResponse(PhantomIdentifyResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.updateInfo_ = ((other.updateInfo_ != null) ? other.updateInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011C92 RID: 72850 RVA: 0x0029A2CC File Offset: 0x002984CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomIdentifyResponse Clone()
		{
			return new PhantomIdentifyResponse(this);
		}

		// Token: 0x17003AEF RID: 15087
		// (get) Token: 0x06011C93 RID: 72851 RVA: 0x0029A2D4 File Offset: 0x002984D4
		// (set) Token: 0x06011C94 RID: 72852 RVA: 0x0029A2DC File Offset: 0x002984DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17003AF0 RID: 15088
		// (get) Token: 0x06011C95 RID: 72853 RVA: 0x0029A2E5 File Offset: 0x002984E5
		// (set) Token: 0x06011C96 RID: 72854 RVA: 0x0029A2ED File Offset: 0x002984ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItem UpdateInfo
		{
			get
			{
				return this.updateInfo_;
			}
			set
			{
				this.updateInfo_ = value;
			}
		}

		// Token: 0x06011C97 RID: 72855 RVA: 0x0029A2F6 File Offset: 0x002984F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomIdentifyResponse);
		}

		// Token: 0x06011C98 RID: 72856 RVA: 0x0029A304 File Offset: 0x00298504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomIdentifyResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.UpdateInfo, other.UpdateInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011C99 RID: 72857 RVA: 0x0029A354 File Offset: 0x00298554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.updateInfo_ != null)
			{
				num ^= this.UpdateInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011C9A RID: 72858 RVA: 0x0029A3AF File Offset: 0x002985AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011C9B RID: 72859 RVA: 0x0029A3BC File Offset: 0x002985BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011C9C RID: 72860 RVA: 0x0029A3C8 File Offset: 0x002985C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.updateInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.UpdateInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011C9D RID: 72861 RVA: 0x0029A424 File Offset: 0x00298624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.updateInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UpdateInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011C9E RID: 72862 RVA: 0x0029A47C File Offset: 0x0029867C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomIdentifyResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.updateInfo_ != null)
			{
				if (this.updateInfo_ == null)
				{
					this.UpdateInfo = new PhantomItem();
				}
				this.UpdateInfo.MergeFrom(other.UpdateInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011C9F RID: 72863 RVA: 0x0029A4E4 File Offset: 0x002986E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011CA0 RID: 72864 RVA: 0x0029A4F0 File Offset: 0x002986F0
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
				if (num != 64U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.updateInfo_ == null)
						{
							this.UpdateInfo = new PhantomItem();
						}
						input.ReadMessage(this.UpdateInfo);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006FB7 RID: 28599
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006FB8 RID: 28600
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04006FB9 RID: 28601
		private ErrorCode errorCode_;

		// Token: 0x04006FBA RID: 28602
		public const int UpdateInfoFieldNumber = 11;

		// Token: 0x04006FBB RID: 28603
		private PhantomItem updateInfo_;
	}
}
