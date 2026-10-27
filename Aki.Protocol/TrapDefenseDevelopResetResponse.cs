using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001422 RID: 5154
	[NetMessage(EMessageId.TrapDefenseDevelopResetResponse)]
	public sealed class TrapDefenseDevelopResetResponse : IMessage<TrapDefenseDevelopResetResponse>, IMessage, IEquatable<TrapDefenseDevelopResetResponse>, IDeepCloneable<TrapDefenseDevelopResetResponse>, IBufferMessage
	{
		// Token: 0x0601B50D RID: 111885 RVA: 0x003F5349 File Offset: 0x003F3549
		[NullableContext(1)]
		public static TrapDefenseDevelopResetResponse Create()
		{
			return new TrapDefenseDevelopResetResponse();
		}

		// Token: 0x17005C23 RID: 23587
		// (get) Token: 0x0601B50E RID: 111886 RVA: 0x003F5350 File Offset: 0x003F3550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C24 RID: 23588
		// (get) Token: 0x0601B50F RID: 111887 RVA: 0x003F5353 File Offset: 0x003F3553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseDevelopResetResponse.Descriptor;
			}
		}

		// Token: 0x0601B510 RID: 111888 RVA: 0x003F535A File Offset: 0x003F355A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseDevelopResetResponse()
		{
		}

		// Token: 0x0601B511 RID: 111889 RVA: 0x003F5362 File Offset: 0x003F3562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseDevelopResetResponse(TrapDefenseDevelopResetResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B512 RID: 111890 RVA: 0x003F5387 File Offset: 0x003F3587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseDevelopResetResponse Clone()
		{
			return new TrapDefenseDevelopResetResponse(this);
		}

		// Token: 0x17005C25 RID: 23589
		// (get) Token: 0x0601B513 RID: 111891 RVA: 0x003F538F File Offset: 0x003F358F
		// (set) Token: 0x0601B514 RID: 111892 RVA: 0x003F5397 File Offset: 0x003F3597
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

		// Token: 0x0601B515 RID: 111893 RVA: 0x003F53A0 File Offset: 0x003F35A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseDevelopResetResponse);
		}

		// Token: 0x0601B516 RID: 111894 RVA: 0x003F53AE File Offset: 0x003F35AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseDevelopResetResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B517 RID: 111895 RVA: 0x003F53DC File Offset: 0x003F35DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B518 RID: 111896 RVA: 0x003F5421 File Offset: 0x003F3621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B519 RID: 111897 RVA: 0x003F542E File Offset: 0x003F362E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B51A RID: 111898 RVA: 0x003F5437 File Offset: 0x003F3637
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B51B RID: 111899 RVA: 0x003F546C File Offset: 0x003F366C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B51C RID: 111900 RVA: 0x003F54AA File Offset: 0x003F36AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseDevelopResetResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B51D RID: 111901 RVA: 0x003F54DB File Offset: 0x003F36DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B51E RID: 111902 RVA: 0x003F54E4 File Offset: 0x003F36E4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009DDD RID: 40413
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DDE RID: 40414
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04009DDF RID: 40415
		private ErrorCode errorCode_;
	}
}
