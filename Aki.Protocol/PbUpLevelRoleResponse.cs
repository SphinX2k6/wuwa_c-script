using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C03 RID: 3075
	[NetMessage(EMessageId.PbUpLevelRoleResponse)]
	public sealed class PbUpLevelRoleResponse : IMessage<PbUpLevelRoleResponse>, IMessage, IEquatable<PbUpLevelRoleResponse>, IDeepCloneable<PbUpLevelRoleResponse>, IBufferMessage
	{
		// Token: 0x06010B74 RID: 68468 RVA: 0x002732C4 File Offset: 0x002714C4
		[NullableContext(1)]
		public static PbUpLevelRoleResponse Create()
		{
			return new PbUpLevelRoleResponse();
		}

		// Token: 0x17003727 RID: 14119
		// (get) Token: 0x06010B75 RID: 68469 RVA: 0x002732CB File Offset: 0x002714CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003728 RID: 14120
		// (get) Token: 0x06010B76 RID: 68470 RVA: 0x002732CE File Offset: 0x002714CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbUpLevelRoleResponse.Descriptor;
			}
		}

		// Token: 0x06010B77 RID: 68471 RVA: 0x002732D5 File Offset: 0x002714D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbUpLevelRoleResponse()
		{
		}

		// Token: 0x06010B78 RID: 68472 RVA: 0x002732E8 File Offset: 0x002714E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbUpLevelRoleResponse(PbUpLevelRoleResponse other) : this()
		{
			this.code_ = other.code_;
			this.roleId_ = other.roleId_;
			this.exp_ = other.exp_;
			this.level_ = other.level_;
			this.itemMap_ = other.itemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010B79 RID: 68473 RVA: 0x0027334D File Offset: 0x0027154D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbUpLevelRoleResponse Clone()
		{
			return new PbUpLevelRoleResponse(this);
		}

		// Token: 0x17003729 RID: 14121
		// (get) Token: 0x06010B7A RID: 68474 RVA: 0x00273355 File Offset: 0x00271555
		// (set) Token: 0x06010B7B RID: 68475 RVA: 0x0027335D File Offset: 0x0027155D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x1700372A RID: 14122
		// (get) Token: 0x06010B7C RID: 68476 RVA: 0x00273366 File Offset: 0x00271566
		// (set) Token: 0x06010B7D RID: 68477 RVA: 0x0027336E File Offset: 0x0027156E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x1700372B RID: 14123
		// (get) Token: 0x06010B7E RID: 68478 RVA: 0x00273377 File Offset: 0x00271577
		// (set) Token: 0x06010B7F RID: 68479 RVA: 0x0027337F File Offset: 0x0027157F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Exp
		{
			get
			{
				return this.exp_;
			}
			set
			{
				this.exp_ = value;
			}
		}

		// Token: 0x1700372C RID: 14124
		// (get) Token: 0x06010B80 RID: 68480 RVA: 0x00273388 File Offset: 0x00271588
		// (set) Token: 0x06010B81 RID: 68481 RVA: 0x00273390 File Offset: 0x00271590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x1700372D RID: 14125
		// (get) Token: 0x06010B82 RID: 68482 RVA: 0x00273399 File Offset: 0x00271599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x06010B83 RID: 68483 RVA: 0x002733A1 File Offset: 0x002715A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbUpLevelRoleResponse);
		}

		// Token: 0x06010B84 RID: 68484 RVA: 0x002733B0 File Offset: 0x002715B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbUpLevelRoleResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.RoleId == other.RoleId && this.Exp == other.Exp && this.Level == other.Level && this.ItemMap.Equals(other.ItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010B85 RID: 68485 RVA: 0x00273430 File Offset: 0x00271630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.Exp != 0)
			{
				num ^= this.Exp.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			num ^= this.ItemMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010B86 RID: 68486 RVA: 0x002734CE File Offset: 0x002716CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010B87 RID: 68487 RVA: 0x002734DB File Offset: 0x002716DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010B88 RID: 68488 RVA: 0x002734E4 File Offset: 0x002716E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.Code);
			}
			this.itemMap_.WriteTo(ref output, PbUpLevelRoleResponse._map_itemMap_codec);
			if (this.RoleId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.RoleId);
			}
			if (this.Exp != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Exp);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010B89 RID: 68489 RVA: 0x00273588 File Offset: 0x00271788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.Exp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Exp);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			num += this.itemMap_.CalculateSize(PbUpLevelRoleResponse._map_itemMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010B8A RID: 68490 RVA: 0x00273624 File Offset: 0x00271824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PbUpLevelRoleResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.Exp != 0)
			{
				this.Exp = other.Exp;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			this.itemMap_.MergeFrom(other.itemMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010B8B RID: 68491 RVA: 0x002736AD File Offset: 0x002718AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010B8C RID: 68492 RVA: 0x002736B8 File Offset: 0x002718B8
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
				if (num <= 66U)
				{
					if (num == 48U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 66U)
					{
						this.itemMap_.AddEntriesFrom(ref input, PbUpLevelRoleResponse._map_itemMap_codec);
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.Exp = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.Level = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006AA3 RID: 27299
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006AA4 RID: 27300
		public const int CodeFieldNumber = 6;

		// Token: 0x04006AA5 RID: 27301
		private ErrorCode code_;

		// Token: 0x04006AA6 RID: 27302
		public const int RoleIdFieldNumber = 10;

		// Token: 0x04006AA7 RID: 27303
		private int roleId_;

		// Token: 0x04006AA8 RID: 27304
		public const int ExpFieldNumber = 13;

		// Token: 0x04006AA9 RID: 27305
		private int exp_;

		// Token: 0x04006AAA RID: 27306
		public const int LevelFieldNumber = 14;

		// Token: 0x04006AAB RID: 27307
		private int level_;

		// Token: 0x04006AAC RID: 27308
		public const int ItemMapFieldNumber = 8;

		// Token: 0x04006AAD RID: 27309
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 66U);

		// Token: 0x04006AAE RID: 27310
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();
	}
}
