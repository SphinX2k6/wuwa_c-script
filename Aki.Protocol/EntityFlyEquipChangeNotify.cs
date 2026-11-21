using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000475 RID: 1141
	[NetMessage(EMessageId.EntityFlyEquipChangeNotify)]
	public sealed class EntityFlyEquipChangeNotify : IMessage<EntityFlyEquipChangeNotify>, IMessage, IEquatable<EntityFlyEquipChangeNotify>, IDeepCloneable<EntityFlyEquipChangeNotify>, IBufferMessage
	{
		// Token: 0x06006DCC RID: 28108 RVA: 0x0010E617 File Offset: 0x0010C817
		[NullableContext(1)]
		public static EntityFlyEquipChangeNotify Create()
		{
			return new EntityFlyEquipChangeNotify();
		}

		// Token: 0x1700151A RID: 5402
		// (get) Token: 0x06006DCD RID: 28109 RVA: 0x0010E61E File Offset: 0x0010C81E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700151B RID: 5403
		// (get) Token: 0x06006DCE RID: 28110 RVA: 0x0010E621 File Offset: 0x0010C821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityFlyEquipChangeNotify.Descriptor;
			}
		}

		// Token: 0x06006DCF RID: 28111 RVA: 0x0010E628 File Offset: 0x0010C828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityFlyEquipChangeNotify()
		{
		}

		// Token: 0x06006DD0 RID: 28112 RVA: 0x0010E63B File Offset: 0x0010C83B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityFlyEquipChangeNotify(EntityFlyEquipChangeNotify other) : this()
		{
			this.skinChanges_ = other.skinChanges_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006DD1 RID: 28113 RVA: 0x0010E665 File Offset: 0x0010C865
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityFlyEquipChangeNotify Clone()
		{
			return new EntityFlyEquipChangeNotify(this);
		}

		// Token: 0x1700151C RID: 5404
		// (get) Token: 0x06006DD2 RID: 28114 RVA: 0x0010E66D File Offset: 0x0010C86D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntityFlySkin> SkinChanges
		{
			get
			{
				return this.skinChanges_;
			}
		}

		// Token: 0x06006DD3 RID: 28115 RVA: 0x0010E675 File Offset: 0x0010C875
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityFlyEquipChangeNotify);
		}

		// Token: 0x06006DD4 RID: 28116 RVA: 0x0010E683 File Offset: 0x0010C883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityFlyEquipChangeNotify other)
		{
			return other != null && (other == this || (this.skinChanges_.Equals(other.skinChanges_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006DD5 RID: 28117 RVA: 0x0010E6B8 File Offset: 0x0010C8B8
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

		// Token: 0x06006DD6 RID: 28118 RVA: 0x0010E6EC File Offset: 0x0010C8EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006DD7 RID: 28119 RVA: 0x0010E6F9 File Offset: 0x0010C8F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006DD8 RID: 28120 RVA: 0x0010E702 File Offset: 0x0010C902
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

		// Token: 0x06006DD9 RID: 28121 RVA: 0x0010E72C File Offset: 0x0010C92C
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

		// Token: 0x06006DDA RID: 28122 RVA: 0x0010E765 File Offset: 0x0010C965
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

		// Token: 0x06006DDB RID: 28123 RVA: 0x0010E793 File Offset: 0x0010C993
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006DDC RID: 28124 RVA: 0x0010E79C File Offset: 0x0010C99C
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.skinChanges_.AddEntriesFrom(ref input, EntityFlyEquipChangeNotify._repeated_skinChanges_codec);
				}
			}
		}

		// Token: 0x04003BD5 RID: 15317
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BD6 RID: 15318
		public const int SkinChangesFieldNumber = 7;

		// Token: 0x04003BD7 RID: 15319
		private static readonly FieldCodec<EntityFlySkin> _repeated_skinChanges_codec = FieldCodec.ForMessage<EntityFlySkin>(58U, EntityFlySkin.Parser);

		// Token: 0x04003BD8 RID: 15320
		private readonly RepeatedField<EntityFlySkin> skinChanges_ = new RepeatedField<EntityFlySkin>();
	}
}
