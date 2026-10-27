using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CD4 RID: 3284
	[NetMessage(EMessageId.PhantomFormationChangeNotify)]
	public sealed class PhantomFormationChangeNotify : IMessage<PhantomFormationChangeNotify>, IMessage, IEquatable<PhantomFormationChangeNotify>, IDeepCloneable<PhantomFormationChangeNotify>, IBufferMessage
	{
		// Token: 0x06011C61 RID: 72801 RVA: 0x00299BD3 File Offset: 0x00297DD3
		[NullableContext(1)]
		public static PhantomFormationChangeNotify Create()
		{
			return new PhantomFormationChangeNotify();
		}

		// Token: 0x17003AE3 RID: 15075
		// (get) Token: 0x06011C62 RID: 72802 RVA: 0x00299BDA File Offset: 0x00297DDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AE4 RID: 15076
		// (get) Token: 0x06011C63 RID: 72803 RVA: 0x00299BDD File Offset: 0x00297DDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomFormationChangeNotify.Descriptor;
			}
		}

		// Token: 0x06011C64 RID: 72804 RVA: 0x00299BE4 File Offset: 0x00297DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomFormationChangeNotify()
		{
		}

		// Token: 0x06011C65 RID: 72805 RVA: 0x00299BF8 File Offset: 0x00297DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomFormationChangeNotify(PhantomFormationChangeNotify other) : this()
		{
			this.currRole_ = other.currRole_;
			this.roleIds_ = other.roleIds_.Clone();
			this.formationId_ = other.formationId_;
			this.isExit_ = other.isExit_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011C66 RID: 72806 RVA: 0x00299C51 File Offset: 0x00297E51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomFormationChangeNotify Clone()
		{
			return new PhantomFormationChangeNotify(this);
		}

		// Token: 0x17003AE5 RID: 15077
		// (get) Token: 0x06011C67 RID: 72807 RVA: 0x00299C59 File Offset: 0x00297E59
		// (set) Token: 0x06011C68 RID: 72808 RVA: 0x00299C61 File Offset: 0x00297E61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurrRole
		{
			get
			{
				return this.currRole_;
			}
			set
			{
				this.currRole_ = value;
			}
		}

		// Token: 0x17003AE6 RID: 15078
		// (get) Token: 0x06011C69 RID: 72809 RVA: 0x00299C6A File Offset: 0x00297E6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x17003AE7 RID: 15079
		// (get) Token: 0x06011C6A RID: 72810 RVA: 0x00299C72 File Offset: 0x00297E72
		// (set) Token: 0x06011C6B RID: 72811 RVA: 0x00299C7A File Offset: 0x00297E7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FormationId
		{
			get
			{
				return this.formationId_;
			}
			set
			{
				this.formationId_ = value;
			}
		}

		// Token: 0x17003AE8 RID: 15080
		// (get) Token: 0x06011C6C RID: 72812 RVA: 0x00299C83 File Offset: 0x00297E83
		// (set) Token: 0x06011C6D RID: 72813 RVA: 0x00299C8B File Offset: 0x00297E8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsExit
		{
			get
			{
				return this.isExit_;
			}
			set
			{
				this.isExit_ = value;
			}
		}

		// Token: 0x06011C6E RID: 72814 RVA: 0x00299C94 File Offset: 0x00297E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomFormationChangeNotify);
		}

		// Token: 0x06011C6F RID: 72815 RVA: 0x00299CA4 File Offset: 0x00297EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomFormationChangeNotify other)
		{
			return other != null && (other == this || (this.CurrRole == other.CurrRole && this.roleIds_.Equals(other.roleIds_) && this.FormationId == other.FormationId && this.IsExit == other.IsExit && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011C70 RID: 72816 RVA: 0x00299D14 File Offset: 0x00297F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurrRole != 0)
			{
				num ^= this.CurrRole.GetHashCode();
			}
			num ^= this.roleIds_.GetHashCode();
			if (this.FormationId != 0)
			{
				num ^= this.FormationId.GetHashCode();
			}
			if (this.IsExit)
			{
				num ^= this.IsExit.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011C71 RID: 72817 RVA: 0x00299D93 File Offset: 0x00297F93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011C72 RID: 72818 RVA: 0x00299DA0 File Offset: 0x00297FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011C73 RID: 72819 RVA: 0x00299DAC File Offset: 0x00297FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleIds_.WriteTo(ref output, PhantomFormationChangeNotify._repeated_roleIds_codec);
			if (this.FormationId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.FormationId);
			}
			if (this.CurrRole != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.CurrRole);
			}
			if (this.IsExit)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IsExit);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011C74 RID: 72820 RVA: 0x00299E34 File Offset: 0x00298034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurrRole != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurrRole);
			}
			num += this.roleIds_.CalculateSize(PhantomFormationChangeNotify._repeated_roleIds_codec);
			if (this.FormationId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FormationId);
			}
			if (this.IsExit)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011C75 RID: 72821 RVA: 0x00299EAC File Offset: 0x002980AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomFormationChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurrRole != 0)
			{
				this.CurrRole = other.CurrRole;
			}
			this.roleIds_.Add(other.roleIds_);
			if (other.FormationId != 0)
			{
				this.FormationId = other.FormationId;
			}
			if (other.IsExit)
			{
				this.IsExit = other.IsExit;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011C76 RID: 72822 RVA: 0x00299F21 File Offset: 0x00298121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011C77 RID: 72823 RVA: 0x00299F2C File Offset: 0x0029812C
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
				if (num <= 18U)
				{
					if (num == 16U || num == 18U)
					{
						this.roleIds_.AddEntriesFrom(ref input, PhantomFormationChangeNotify._repeated_roleIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.FormationId = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.CurrRole = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.IsExit = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006FA8 RID: 28584
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006FA9 RID: 28585
		public const int CurrRoleFieldNumber = 8;

		// Token: 0x04006FAA RID: 28586
		private int currRole_;

		// Token: 0x04006FAB RID: 28587
		public const int RoleIdsFieldNumber = 2;

		// Token: 0x04006FAC RID: 28588
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04006FAD RID: 28589
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();

		// Token: 0x04006FAE RID: 28590
		public const int FormationIdFieldNumber = 6;

		// Token: 0x04006FAF RID: 28591
		private int formationId_;

		// Token: 0x04006FB0 RID: 28592
		public const int IsExitFieldNumber = 14;

		// Token: 0x04006FB1 RID: 28593
		private bool isExit_;
	}
}
