using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D7A RID: 3450
	[NetMessage(EMessageId.PlayerAccessCasketResponse)]
	public sealed class PlayerAccessCasketResponse : IMessage<PlayerAccessCasketResponse>, IMessage, IEquatable<PlayerAccessCasketResponse>, IDeepCloneable<PlayerAccessCasketResponse>, IBufferMessage
	{
		// Token: 0x06012990 RID: 76176 RVA: 0x002B67E2 File Offset: 0x002B49E2
		[NullableContext(1)]
		public static PlayerAccessCasketResponse Create()
		{
			return new PlayerAccessCasketResponse();
		}

		// Token: 0x17003DA7 RID: 15783
		// (get) Token: 0x06012991 RID: 76177 RVA: 0x002B67E9 File Offset: 0x002B49E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DA8 RID: 15784
		// (get) Token: 0x06012992 RID: 76178 RVA: 0x002B67EC File Offset: 0x002B49EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerAccessCasketResponse.Descriptor;
			}
		}

		// Token: 0x06012993 RID: 76179 RVA: 0x002B67F3 File Offset: 0x002B49F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAccessCasketResponse()
		{
		}

		// Token: 0x06012994 RID: 76180 RVA: 0x002B67FB File Offset: 0x002B49FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAccessCasketResponse(PlayerAccessCasketResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.casketEntityIncId_ = other.casketEntityIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012995 RID: 76181 RVA: 0x002B682C File Offset: 0x002B4A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAccessCasketResponse Clone()
		{
			return new PlayerAccessCasketResponse(this);
		}

		// Token: 0x17003DA9 RID: 15785
		// (get) Token: 0x06012996 RID: 76182 RVA: 0x002B6834 File Offset: 0x002B4A34
		// (set) Token: 0x06012997 RID: 76183 RVA: 0x002B683C File Offset: 0x002B4A3C
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

		// Token: 0x17003DAA RID: 15786
		// (get) Token: 0x06012998 RID: 76184 RVA: 0x002B6845 File Offset: 0x002B4A45
		// (set) Token: 0x06012999 RID: 76185 RVA: 0x002B684D File Offset: 0x002B4A4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CasketEntityIncId
		{
			get
			{
				return this.casketEntityIncId_;
			}
			set
			{
				this.casketEntityIncId_ = value;
			}
		}

		// Token: 0x0601299A RID: 76186 RVA: 0x002B6856 File Offset: 0x002B4A56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerAccessCasketResponse);
		}

		// Token: 0x0601299B RID: 76187 RVA: 0x002B6864 File Offset: 0x002B4A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerAccessCasketResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.CasketEntityIncId == other.CasketEntityIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601299C RID: 76188 RVA: 0x002B68A4 File Offset: 0x002B4AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.CasketEntityIncId != 0L)
			{
				num ^= this.CasketEntityIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601299D RID: 76189 RVA: 0x002B6902 File Offset: 0x002B4B02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601299E RID: 76190 RVA: 0x002B690F File Offset: 0x002B4B0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601299F RID: 76191 RVA: 0x002B6918 File Offset: 0x002B4B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CasketEntityIncId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.CasketEntityIncId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060129A0 RID: 76192 RVA: 0x002B6974 File Offset: 0x002B4B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.CasketEntityIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CasketEntityIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060129A1 RID: 76193 RVA: 0x002B69CC File Offset: 0x002B4BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerAccessCasketResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.CasketEntityIncId != 0L)
			{
				this.CasketEntityIncId = other.CasketEntityIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060129A2 RID: 76194 RVA: 0x002B6A1C File Offset: 0x002B4C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060129A3 RID: 76195 RVA: 0x002B6A28 File Offset: 0x002B4C28
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
				if (num != 32U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.CasketEntityIncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007371 RID: 29553
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007372 RID: 29554
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04007373 RID: 29555
		private ErrorCode errorCode_;

		// Token: 0x04007374 RID: 29556
		public const int CasketEntityIncIdFieldNumber = 4;

		// Token: 0x04007375 RID: 29557
		private long casketEntityIncId_;
	}
}
