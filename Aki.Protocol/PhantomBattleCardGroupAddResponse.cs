using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C48 RID: 3144
	[NetMessage(EMessageId.PhantomBattleCardGroupAddResponse)]
	public sealed class PhantomBattleCardGroupAddResponse : IMessage<PhantomBattleCardGroupAddResponse>, IMessage, IEquatable<PhantomBattleCardGroupAddResponse>, IDeepCloneable<PhantomBattleCardGroupAddResponse>, IBufferMessage
	{
		// Token: 0x060110D5 RID: 69845 RVA: 0x0027F4FE File Offset: 0x0027D6FE
		[NullableContext(1)]
		public static PhantomBattleCardGroupAddResponse Create()
		{
			return new PhantomBattleCardGroupAddResponse();
		}

		// Token: 0x1700385B RID: 14427
		// (get) Token: 0x060110D6 RID: 69846 RVA: 0x0027F505 File Offset: 0x0027D705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700385C RID: 14428
		// (get) Token: 0x060110D7 RID: 69847 RVA: 0x0027F508 File Offset: 0x0027D708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardGroupAddResponse.Descriptor;
			}
		}

		// Token: 0x060110D8 RID: 69848 RVA: 0x0027F50F File Offset: 0x0027D70F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupAddResponse()
		{
		}

		// Token: 0x060110D9 RID: 69849 RVA: 0x0027F518 File Offset: 0x0027D718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupAddResponse(PhantomBattleCardGroupAddResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomBattleCardGroupInfo_ = ((other.phantomBattleCardGroupInfo_ != null) ? other.phantomBattleCardGroupInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060110DA RID: 69850 RVA: 0x0027F564 File Offset: 0x0027D764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupAddResponse Clone()
		{
			return new PhantomBattleCardGroupAddResponse(this);
		}

		// Token: 0x1700385D RID: 14429
		// (get) Token: 0x060110DB RID: 69851 RVA: 0x0027F56C File Offset: 0x0027D76C
		// (set) Token: 0x060110DC RID: 69852 RVA: 0x0027F574 File Offset: 0x0027D774
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

		// Token: 0x1700385E RID: 14430
		// (get) Token: 0x060110DD RID: 69853 RVA: 0x0027F57D File Offset: 0x0027D77D
		// (set) Token: 0x060110DE RID: 69854 RVA: 0x0027F585 File Offset: 0x0027D785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupInfo PhantomBattleCardGroupInfo
		{
			get
			{
				return this.phantomBattleCardGroupInfo_;
			}
			set
			{
				this.phantomBattleCardGroupInfo_ = value;
			}
		}

		// Token: 0x060110DF RID: 69855 RVA: 0x0027F58E File Offset: 0x0027D78E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardGroupAddResponse);
		}

		// Token: 0x060110E0 RID: 69856 RVA: 0x0027F59C File Offset: 0x0027D79C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardGroupAddResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PhantomBattleCardGroupInfo, other.PhantomBattleCardGroupInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060110E1 RID: 69857 RVA: 0x0027F5EC File Offset: 0x0027D7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.phantomBattleCardGroupInfo_ != null)
			{
				num ^= this.PhantomBattleCardGroupInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060110E2 RID: 69858 RVA: 0x0027F647 File Offset: 0x0027D847
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060110E3 RID: 69859 RVA: 0x0027F654 File Offset: 0x0027D854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060110E4 RID: 69860 RVA: 0x0027F660 File Offset: 0x0027D860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.phantomBattleCardGroupInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.PhantomBattleCardGroupInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060110E5 RID: 69861 RVA: 0x0027F6BC File Offset: 0x0027D8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.phantomBattleCardGroupInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleCardGroupInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060110E6 RID: 69862 RVA: 0x0027F714 File Offset: 0x0027D914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardGroupAddResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.phantomBattleCardGroupInfo_ != null)
			{
				if (this.phantomBattleCardGroupInfo_ == null)
				{
					this.PhantomBattleCardGroupInfo = new PhantomBattleCardGroupInfo();
				}
				this.PhantomBattleCardGroupInfo.MergeFrom(other.PhantomBattleCardGroupInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060110E7 RID: 69863 RVA: 0x0027F77C File Offset: 0x0027D97C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060110E8 RID: 69864 RVA: 0x0027F788 File Offset: 0x0027D988
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
				if (num != 88U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.phantomBattleCardGroupInfo_ == null)
						{
							this.PhantomBattleCardGroupInfo = new PhantomBattleCardGroupInfo();
						}
						input.ReadMessage(this.PhantomBattleCardGroupInfo);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006C13 RID: 27667
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C14 RID: 27668
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04006C15 RID: 27669
		private ErrorCode errorCode_;

		// Token: 0x04006C16 RID: 27670
		public const int PhantomBattleCardGroupInfoFieldNumber = 15;

		// Token: 0x04006C17 RID: 27671
		private PhantomBattleCardGroupInfo phantomBattleCardGroupInfo_;
	}
}
