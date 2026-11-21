using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000338 RID: 824
	[NetMessage(EMessageId.DamageShowNotify)]
	public sealed class DamageShowNotify : IMessage<DamageShowNotify>, IMessage, IEquatable<DamageShowNotify>, IDeepCloneable<DamageShowNotify>, IBufferMessage
	{
		// Token: 0x060052FF RID: 21247 RVA: 0x000CAC8E File Offset: 0x000C8E8E
		[NullableContext(1)]
		public static DamageShowNotify Create()
		{
			return new DamageShowNotify();
		}

		// Token: 0x17000F0B RID: 3851
		// (get) Token: 0x06005300 RID: 21248 RVA: 0x000CAC95 File Offset: 0x000C8E95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F0C RID: 3852
		// (get) Token: 0x06005301 RID: 21249 RVA: 0x000CAC98 File Offset: 0x000C8E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DamageShowNotify.Descriptor;
			}
		}

		// Token: 0x06005302 RID: 21250 RVA: 0x000CAC9F File Offset: 0x000C8E9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageShowNotify()
		{
		}

		// Token: 0x06005303 RID: 21251 RVA: 0x000CACA7 File Offset: 0x000C8EA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageShowNotify(DamageShowNotify other) : this()
		{
			this.id_ = other.id_;
			this.damage_ = other.damage_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005304 RID: 21252 RVA: 0x000CACD8 File Offset: 0x000C8ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageShowNotify Clone()
		{
			return new DamageShowNotify(this);
		}

		// Token: 0x17000F0D RID: 3853
		// (get) Token: 0x06005305 RID: 21253 RVA: 0x000CACE0 File Offset: 0x000C8EE0
		// (set) Token: 0x06005306 RID: 21254 RVA: 0x000CACE8 File Offset: 0x000C8EE8
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

		// Token: 0x17000F0E RID: 3854
		// (get) Token: 0x06005307 RID: 21255 RVA: 0x000CACF1 File Offset: 0x000C8EF1
		// (set) Token: 0x06005308 RID: 21256 RVA: 0x000CACF9 File Offset: 0x000C8EF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Damage
		{
			get
			{
				return this.damage_;
			}
			set
			{
				this.damage_ = value;
			}
		}

		// Token: 0x06005309 RID: 21257 RVA: 0x000CAD02 File Offset: 0x000C8F02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DamageShowNotify);
		}

		// Token: 0x0600530A RID: 21258 RVA: 0x000CAD10 File Offset: 0x000C8F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DamageShowNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Damage == other.Damage && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600530B RID: 21259 RVA: 0x000CAD50 File Offset: 0x000C8F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Damage != 0)
			{
				num ^= this.Damage.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600530C RID: 21260 RVA: 0x000CADA8 File Offset: 0x000C8FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600530D RID: 21261 RVA: 0x000CADB5 File Offset: 0x000C8FB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600530E RID: 21262 RVA: 0x000CADC0 File Offset: 0x000C8FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Damage != 0)
			{
				output.WriteRawTag(16);
				output.WriteSInt32(this.Damage);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600530F RID: 21263 RVA: 0x000CAE1C File Offset: 0x000C901C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Damage != 0)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.Damage);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005310 RID: 21264 RVA: 0x000CAE74 File Offset: 0x000C9074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DamageShowNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Damage != 0)
			{
				this.Damage = other.Damage;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005311 RID: 21265 RVA: 0x000CAEC4 File Offset: 0x000C90C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005312 RID: 21266 RVA: 0x000CAED0 File Offset: 0x000C90D0
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
				if (num != 16U)
				{
					if (num != 64U)
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
					this.Damage = input.ReadSInt32();
				}
			}
		}

		// Token: 0x040033AA RID: 13226
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033AB RID: 13227
		public const int IdFieldNumber = 8;

		// Token: 0x040033AC RID: 13228
		private int id_;

		// Token: 0x040033AD RID: 13229
		public const int DamageFieldNumber = 2;

		// Token: 0x040033AE RID: 13230
		private int damage_;
	}
}
