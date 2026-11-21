using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200106C RID: 4204
	[NetMessage(EMessageId.RoleFlyEquipChangeNotify)]
	public sealed class RoleFlyEquipChangeNotify : IMessage<RoleFlyEquipChangeNotify>, IMessage, IEquatable<RoleFlyEquipChangeNotify>, IDeepCloneable<RoleFlyEquipChangeNotify>, IBufferMessage
	{
		// Token: 0x060167DB RID: 92123 RVA: 0x00345A58 File Offset: 0x00343C58
		[NullableContext(1)]
		public static RoleFlyEquipChangeNotify Create()
		{
			return new RoleFlyEquipChangeNotify();
		}

		// Token: 0x17004B54 RID: 19284
		// (get) Token: 0x060167DC RID: 92124 RVA: 0x00345A5F File Offset: 0x00343C5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B55 RID: 19285
		// (get) Token: 0x060167DD RID: 92125 RVA: 0x00345A62 File Offset: 0x00343C62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFlyEquipChangeNotify.Descriptor;
			}
		}

		// Token: 0x060167DE RID: 92126 RVA: 0x00345A69 File Offset: 0x00343C69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFlyEquipChangeNotify()
		{
		}

		// Token: 0x060167DF RID: 92127 RVA: 0x00345A7C File Offset: 0x00343C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFlyEquipChangeNotify(RoleFlyEquipChangeNotify other) : this()
		{
			this.skinChanges_ = other.skinChanges_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060167E0 RID: 92128 RVA: 0x00345AA6 File Offset: 0x00343CA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFlyEquipChangeNotify Clone()
		{
			return new RoleFlyEquipChangeNotify(this);
		}

		// Token: 0x17004B56 RID: 19286
		// (get) Token: 0x060167E1 RID: 92129 RVA: 0x00345AAE File Offset: 0x00343CAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleFlySkinChange> SkinChanges
		{
			get
			{
				return this.skinChanges_;
			}
		}

		// Token: 0x060167E2 RID: 92130 RVA: 0x00345AB6 File Offset: 0x00343CB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFlyEquipChangeNotify);
		}

		// Token: 0x060167E3 RID: 92131 RVA: 0x00345AC4 File Offset: 0x00343CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFlyEquipChangeNotify other)
		{
			return other != null && (other == this || (this.skinChanges_.Equals(other.skinChanges_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060167E4 RID: 92132 RVA: 0x00345AF8 File Offset: 0x00343CF8
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

		// Token: 0x060167E5 RID: 92133 RVA: 0x00345B2C File Offset: 0x00343D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060167E6 RID: 92134 RVA: 0x00345B39 File Offset: 0x00343D39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060167E7 RID: 92135 RVA: 0x00345B42 File Offset: 0x00343D42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.skinChanges_.WriteTo(ref output, RoleFlyEquipChangeNotify._repeated_skinChanges_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060167E8 RID: 92136 RVA: 0x00345B6C File Offset: 0x00343D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.skinChanges_.CalculateSize(RoleFlyEquipChangeNotify._repeated_skinChanges_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060167E9 RID: 92137 RVA: 0x00345BA5 File Offset: 0x00343DA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleFlyEquipChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.skinChanges_.Add(other.skinChanges_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060167EA RID: 92138 RVA: 0x00345BD3 File Offset: 0x00343DD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060167EB RID: 92139 RVA: 0x00345BDC File Offset: 0x00343DDC
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.skinChanges_.AddEntriesFrom(ref input, RoleFlyEquipChangeNotify._repeated_skinChanges_codec);
				}
			}
		}

		// Token: 0x040086F2 RID: 34546
		private UnknownFieldSet _unknownFields;

		// Token: 0x040086F3 RID: 34547
		public const int SkinChangesFieldNumber = 12;

		// Token: 0x040086F4 RID: 34548
		private static readonly FieldCodec<RoleFlySkinChange> _repeated_skinChanges_codec = FieldCodec.ForMessage<RoleFlySkinChange>(98U, RoleFlySkinChange.Parser);

		// Token: 0x040086F5 RID: 34549
		private readonly RepeatedField<RoleFlySkinChange> skinChanges_ = new RepeatedField<RoleFlySkinChange>();
	}
}
