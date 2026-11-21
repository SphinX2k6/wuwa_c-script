using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CC4 RID: 3268
	[NetMessage(EMessageId.PhantomFormationChangeNotify)]
	public sealed class PhantomFormationChangeNotify : IMessage<PhantomFormationChangeNotify>, IMessage, IEquatable<PhantomFormationChangeNotify>, IDeepCloneable<PhantomFormationChangeNotify>, IBufferMessage
	{
		// Token: 0x06011B65 RID: 72549 RVA: 0x00297FB8 File Offset: 0x002961B8
		[NullableContext(1)]
		public static PhantomFormationChangeNotify Create()
		{
			return new PhantomFormationChangeNotify();
		}

		// Token: 0x17003AAE RID: 15022
		// (get) Token: 0x06011B66 RID: 72550 RVA: 0x00297FBF File Offset: 0x002961BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AAF RID: 15023
		// (get) Token: 0x06011B67 RID: 72551 RVA: 0x00297FC2 File Offset: 0x002961C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomFormationChangeNotify.Descriptor;
			}
		}

		// Token: 0x06011B68 RID: 72552 RVA: 0x00297FC9 File Offset: 0x002961C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomFormationChangeNotify()
		{
		}

		// Token: 0x06011B69 RID: 72553 RVA: 0x00297FDC File Offset: 0x002961DC
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

		// Token: 0x06011B6A RID: 72554 RVA: 0x00298035 File Offset: 0x00296235
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomFormationChangeNotify Clone()
		{
			return new PhantomFormationChangeNotify(this);
		}

		// Token: 0x17003AB0 RID: 15024
		// (get) Token: 0x06011B6B RID: 72555 RVA: 0x0029803D File Offset: 0x0029623D
		// (set) Token: 0x06011B6C RID: 72556 RVA: 0x00298045 File Offset: 0x00296245
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

		// Token: 0x17003AB1 RID: 15025
		// (get) Token: 0x06011B6D RID: 72557 RVA: 0x0029804E File Offset: 0x0029624E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x17003AB2 RID: 15026
		// (get) Token: 0x06011B6E RID: 72558 RVA: 0x00298056 File Offset: 0x00296256
		// (set) Token: 0x06011B6F RID: 72559 RVA: 0x0029805E File Offset: 0x0029625E
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

		// Token: 0x17003AB3 RID: 15027
		// (get) Token: 0x06011B70 RID: 72560 RVA: 0x00298067 File Offset: 0x00296267
		// (set) Token: 0x06011B71 RID: 72561 RVA: 0x0029806F File Offset: 0x0029626F
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

		// Token: 0x06011B72 RID: 72562 RVA: 0x00298078 File Offset: 0x00296278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomFormationChangeNotify);
		}

		// Token: 0x06011B73 RID: 72563 RVA: 0x00298088 File Offset: 0x00296288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomFormationChangeNotify other)
		{
			return other != null && (other == this || (this.CurrRole == other.CurrRole && this.roleIds_.Equals(other.roleIds_) && this.FormationId == other.FormationId && this.IsExit == other.IsExit && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011B74 RID: 72564 RVA: 0x002980F8 File Offset: 0x002962F8
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

		// Token: 0x06011B75 RID: 72565 RVA: 0x00298177 File Offset: 0x00296377
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011B76 RID: 72566 RVA: 0x00298184 File Offset: 0x00296384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011B77 RID: 72567 RVA: 0x00298190 File Offset: 0x00296390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurrRole != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CurrRole);
			}
			if (this.IsExit)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsExit);
			}
			this.roleIds_.WriteTo(ref output, PhantomFormationChangeNotify._repeated_roleIds_codec);
			if (this.FormationId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.FormationId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011B78 RID: 72568 RVA: 0x00298218 File Offset: 0x00296418
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

		// Token: 0x06011B79 RID: 72569 RVA: 0x00298290 File Offset: 0x00296490
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

		// Token: 0x06011B7A RID: 72570 RVA: 0x00298305 File Offset: 0x00296505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011B7B RID: 72571 RVA: 0x00298310 File Offset: 0x00296510
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
				if (num <= 48U)
				{
					if (num == 32U)
					{
						this.CurrRole = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.IsExit = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 56U || num == 58U)
					{
						this.roleIds_.AddEntriesFrom(ref input, PhantomFormationChangeNotify._repeated_roleIds_codec);
						continue;
					}
					if (num == 88U)
					{
						this.FormationId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006FC0 RID: 28608
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006FC1 RID: 28609
		public const int CurrRoleFieldNumber = 4;

		// Token: 0x04006FC2 RID: 28610
		private int currRole_;

		// Token: 0x04006FC3 RID: 28611
		public const int RoleIdsFieldNumber = 7;

		// Token: 0x04006FC4 RID: 28612
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04006FC5 RID: 28613
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();

		// Token: 0x04006FC6 RID: 28614
		public const int FormationIdFieldNumber = 11;

		// Token: 0x04006FC7 RID: 28615
		private int formationId_;

		// Token: 0x04006FC8 RID: 28616
		public const int IsExitFieldNumber = 6;

		// Token: 0x04006FC9 RID: 28617
		private bool isExit_;
	}
}
