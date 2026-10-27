using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200048C RID: 1164
	[NetMessage(EMessageId.EntityFlyEquipChangeNotify)]
	public sealed class EntityFlyEquipChangeNotify : IMessage<EntityFlyEquipChangeNotify>, IMessage, IEquatable<EntityFlyEquipChangeNotify>, IDeepCloneable<EntityFlyEquipChangeNotify>, IBufferMessage
	{
		// Token: 0x06006F5A RID: 28506 RVA: 0x0011168B File Offset: 0x0010F88B
		[NullableContext(1)]
		public static EntityFlyEquipChangeNotify Create()
		{
			return new EntityFlyEquipChangeNotify();
		}

		// Token: 0x1700156E RID: 5486
		// (get) Token: 0x06006F5B RID: 28507 RVA: 0x00111692 File Offset: 0x0010F892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700156F RID: 5487
		// (get) Token: 0x06006F5C RID: 28508 RVA: 0x00111695 File Offset: 0x0010F895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityFlyEquipChangeNotify.Descriptor;
			}
		}

		// Token: 0x06006F5D RID: 28509 RVA: 0x0011169C File Offset: 0x0010F89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityFlyEquipChangeNotify()
		{
		}

		// Token: 0x06006F5E RID: 28510 RVA: 0x001116AF File Offset: 0x0010F8AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityFlyEquipChangeNotify(EntityFlyEquipChangeNotify other) : this()
		{
			this.skinChanges_ = other.skinChanges_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006F5F RID: 28511 RVA: 0x001116D9 File Offset: 0x0010F8D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityFlyEquipChangeNotify Clone()
		{
			return new EntityFlyEquipChangeNotify(this);
		}

		// Token: 0x17001570 RID: 5488
		// (get) Token: 0x06006F60 RID: 28512 RVA: 0x001116E1 File Offset: 0x0010F8E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntityFlySkin> SkinChanges
		{
			get
			{
				return this.skinChanges_;
			}
		}

		// Token: 0x06006F61 RID: 28513 RVA: 0x001116E9 File Offset: 0x0010F8E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityFlyEquipChangeNotify);
		}

		// Token: 0x06006F62 RID: 28514 RVA: 0x001116F7 File Offset: 0x0010F8F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityFlyEquipChangeNotify other)
		{
			return other != null && (other == this || (this.skinChanges_.Equals(other.skinChanges_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006F63 RID: 28515 RVA: 0x0011172C File Offset: 0x0010F92C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.skinChanges_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006F64 RID: 28516 RVA: 0x00111760 File Offset: 0x0010F960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006F65 RID: 28517 RVA: 0x0011176D File Offset: 0x0010F96D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006F66 RID: 28518 RVA: 0x00111776 File Offset: 0x0010F976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.skinChanges_.WriteTo(ref output, EntityFlyEquipChangeNotify._repeated_skinChanges_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006F67 RID: 28519 RVA: 0x001117A0 File Offset: 0x0010F9A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.skinChanges_.CalculateSize(EntityFlyEquipChangeNotify._repeated_skinChanges_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006F68 RID: 28520 RVA: 0x001117D9 File Offset: 0x0010F9D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityFlyEquipChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.skinChanges_.Add(other.skinChanges_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006F69 RID: 28521 RVA: 0x00111807 File Offset: 0x0010FA07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006F6A RID: 28522 RVA: 0x00111810 File Offset: 0x0010FA10
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.skinChanges_.AddEntriesFrom(ref input, EntityFlyEquipChangeNotify._repeated_skinChanges_codec);
				}
			}
		}

		// Token: 0x04003BE7 RID: 15335
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BE8 RID: 15336
		public const int SkinChangesFieldNumber = 8;

		// Token: 0x04003BE9 RID: 15337
		private static readonly FieldCodec<EntityFlySkin> _repeated_skinChanges_codec = FieldCodec.ForMessage<EntityFlySkin>(66U, EntityFlySkin.Parser);

		// Token: 0x04003BEA RID: 15338
		private readonly RepeatedField<EntityFlySkin> skinChanges_ = new RepeatedField<EntityFlySkin>();
	}
}
