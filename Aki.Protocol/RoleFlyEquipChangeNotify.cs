using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200107C RID: 4220
	[NetMessage(EMessageId.RoleFlyEquipChangeNotify)]
	public sealed class RoleFlyEquipChangeNotify : IMessage<RoleFlyEquipChangeNotify>, IMessage, IEquatable<RoleFlyEquipChangeNotify>, IDeepCloneable<RoleFlyEquipChangeNotify>, IBufferMessage
	{
		// Token: 0x060168C0 RID: 92352 RVA: 0x00347131 File Offset: 0x00345331
		[NullableContext(1)]
		public static RoleFlyEquipChangeNotify Create()
		{
			return new RoleFlyEquipChangeNotify();
		}

		// Token: 0x17004B7E RID: 19326
		// (get) Token: 0x060168C1 RID: 92353 RVA: 0x00347138 File Offset: 0x00345338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B7F RID: 19327
		// (get) Token: 0x060168C2 RID: 92354 RVA: 0x0034713B File Offset: 0x0034533B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFlyEquipChangeNotify.Descriptor;
			}
		}

		// Token: 0x060168C3 RID: 92355 RVA: 0x00347142 File Offset: 0x00345342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFlyEquipChangeNotify()
		{
		}

		// Token: 0x060168C4 RID: 92356 RVA: 0x00347155 File Offset: 0x00345355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFlyEquipChangeNotify(RoleFlyEquipChangeNotify other) : this()
		{
			this.skinChanges_ = other.skinChanges_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060168C5 RID: 92357 RVA: 0x0034717F File Offset: 0x0034537F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFlyEquipChangeNotify Clone()
		{
			return new RoleFlyEquipChangeNotify(this);
		}

		// Token: 0x17004B80 RID: 19328
		// (get) Token: 0x060168C6 RID: 92358 RVA: 0x00347187 File Offset: 0x00345387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleFlySkinChange> SkinChanges
		{
			get
			{
				return this.skinChanges_;
			}
		}

		// Token: 0x060168C7 RID: 92359 RVA: 0x0034718F File Offset: 0x0034538F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFlyEquipChangeNotify);
		}

		// Token: 0x060168C8 RID: 92360 RVA: 0x0034719D File Offset: 0x0034539D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFlyEquipChangeNotify other)
		{
			return other != null && (other == this || (this.skinChanges_.Equals(other.skinChanges_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060168C9 RID: 92361 RVA: 0x003471D0 File Offset: 0x003453D0
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

		// Token: 0x060168CA RID: 92362 RVA: 0x00347204 File Offset: 0x00345404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060168CB RID: 92363 RVA: 0x00347211 File Offset: 0x00345411
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060168CC RID: 92364 RVA: 0x0034721A File Offset: 0x0034541A
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

		// Token: 0x060168CD RID: 92365 RVA: 0x00347244 File Offset: 0x00345444
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

		// Token: 0x060168CE RID: 92366 RVA: 0x0034727D File Offset: 0x0034547D
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

		// Token: 0x060168CF RID: 92367 RVA: 0x003472AB File Offset: 0x003454AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060168D0 RID: 92368 RVA: 0x003472B4 File Offset: 0x003454B4
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.skinChanges_.AddEntriesFrom(ref input, RoleFlyEquipChangeNotify._repeated_skinChanges_codec);
				}
			}
		}

		// Token: 0x040086C8 RID: 34504
		private UnknownFieldSet _unknownFields;

		// Token: 0x040086C9 RID: 34505
		public const int SkinChangesFieldNumber = 13;

		// Token: 0x040086CA RID: 34506
		private static readonly FieldCodec<RoleFlySkinChange> _repeated_skinChanges_codec = FieldCodec.ForMessage<RoleFlySkinChange>(106U, RoleFlySkinChange.Parser);

		// Token: 0x040086CB RID: 34507
		private readonly RepeatedField<RoleFlySkinChange> skinChanges_ = new RepeatedField<RoleFlySkinChange>();
	}
}
