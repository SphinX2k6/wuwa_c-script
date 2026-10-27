using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009ED RID: 2541
	[NetMessage(EMessageId.ModifyNameResponse)]
	public sealed class ModifyNameResponse : IMessage<ModifyNameResponse>, IMessage, IEquatable<ModifyNameResponse>, IDeepCloneable<ModifyNameResponse>, IBufferMessage
	{
		// Token: 0x0600DE8F RID: 56975 RVA: 0x0020A29D File Offset: 0x0020849D
		[NullableContext(1)]
		public static ModifyNameResponse Create()
		{
			return new ModifyNameResponse();
		}

		// Token: 0x17002D1B RID: 11547
		// (get) Token: 0x0600DE90 RID: 56976 RVA: 0x0020A2A4 File Offset: 0x002084A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D1C RID: 11548
		// (get) Token: 0x0600DE91 RID: 56977 RVA: 0x0020A2A7 File Offset: 0x002084A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ModifyNameResponse.Descriptor;
			}
		}

		// Token: 0x0600DE92 RID: 56978 RVA: 0x0020A2AE File Offset: 0x002084AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyNameResponse()
		{
		}

		// Token: 0x0600DE93 RID: 56979 RVA: 0x0020A2CC File Offset: 0x002084CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyNameResponse(ModifyNameResponse other) : this()
		{
			this.name_ = other.name_;
			this.errorCode_ = other.errorCode_;
			this.lastModifyNameTime_ = other.lastModifyNameTime_;
			this.modifyName_ = other.modifyName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DE94 RID: 56980 RVA: 0x0020A320 File Offset: 0x00208520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyNameResponse Clone()
		{
			return new ModifyNameResponse(this);
		}

		// Token: 0x17002D1D RID: 11549
		// (get) Token: 0x0600DE95 RID: 56981 RVA: 0x0020A328 File Offset: 0x00208528
		// (set) Token: 0x0600DE96 RID: 56982 RVA: 0x0020A330 File Offset: 0x00208530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002D1E RID: 11550
		// (get) Token: 0x0600DE97 RID: 56983 RVA: 0x0020A343 File Offset: 0x00208543
		// (set) Token: 0x0600DE98 RID: 56984 RVA: 0x0020A34B File Offset: 0x0020854B
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

		// Token: 0x17002D1F RID: 11551
		// (get) Token: 0x0600DE99 RID: 56985 RVA: 0x0020A354 File Offset: 0x00208554
		// (set) Token: 0x0600DE9A RID: 56986 RVA: 0x0020A35C File Offset: 0x0020855C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LastModifyNameTime
		{
			get
			{
				return this.lastModifyNameTime_;
			}
			set
			{
				this.lastModifyNameTime_ = value;
			}
		}

		// Token: 0x17002D20 RID: 11552
		// (get) Token: 0x0600DE9B RID: 56987 RVA: 0x0020A365 File Offset: 0x00208565
		// (set) Token: 0x0600DE9C RID: 56988 RVA: 0x0020A36D File Offset: 0x0020856D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ModifyName
		{
			get
			{
				return this.modifyName_;
			}
			set
			{
				this.modifyName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600DE9D RID: 56989 RVA: 0x0020A380 File Offset: 0x00208580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ModifyNameResponse);
		}

		// Token: 0x0600DE9E RID: 56990 RVA: 0x0020A390 File Offset: 0x00208590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ModifyNameResponse other)
		{
			return other != null && (other == this || (!(this.Name != other.Name) && this.ErrorCode == other.ErrorCode && this.LastModifyNameTime == other.LastModifyNameTime && !(this.ModifyName != other.ModifyName) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DE9F RID: 56991 RVA: 0x0020A404 File Offset: 0x00208604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.LastModifyNameTime != 0L)
			{
				num ^= this.LastModifyNameTime.GetHashCode();
			}
			if (this.ModifyName.Length != 0)
			{
				num ^= this.ModifyName.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DEA0 RID: 56992 RVA: 0x0020A498 File Offset: 0x00208698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DEA1 RID: 56993 RVA: 0x0020A4A5 File Offset: 0x002086A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DEA2 RID: 56994 RVA: 0x0020A4B0 File Offset: 0x002086B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.Name);
			}
			if (this.LastModifyNameTime != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.LastModifyNameTime);
			}
			if (this.ModifyName.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.ModifyName);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DEA3 RID: 56995 RVA: 0x0020A54C File Offset: 0x0020874C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.LastModifyNameTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LastModifyNameTime);
			}
			if (this.ModifyName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ModifyName);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DEA4 RID: 56996 RVA: 0x0020A5DC File Offset: 0x002087DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ModifyNameResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.LastModifyNameTime != 0L)
			{
				this.LastModifyNameTime = other.LastModifyNameTime;
			}
			if (other.ModifyName.Length != 0)
			{
				this.ModifyName = other.ModifyName;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DEA5 RID: 56997 RVA: 0x0020A65E File Offset: 0x0020885E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DEA6 RID: 56998 RVA: 0x0020A668 File Offset: 0x00208868
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
				if (num <= 42U)
				{
					if (num == 16U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 42U)
					{
						this.Name = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.LastModifyNameTime = input.ReadInt64();
						continue;
					}
					if (num == 114U)
					{
						this.ModifyName = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005BDB RID: 23515
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BDC RID: 23516
		public const int NameFieldNumber = 5;

		// Token: 0x04005BDD RID: 23517
		private string name_ = "";

		// Token: 0x04005BDE RID: 23518
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04005BDF RID: 23519
		private ErrorCode errorCode_;

		// Token: 0x04005BE0 RID: 23520
		public const int LastModifyNameTimeFieldNumber = 8;

		// Token: 0x04005BE1 RID: 23521
		private long lastModifyNameTime_;

		// Token: 0x04005BE2 RID: 23522
		public const int ModifyNameFieldNumber = 14;

		// Token: 0x04005BE3 RID: 23523
		private string modifyName_ = "";
	}
}
