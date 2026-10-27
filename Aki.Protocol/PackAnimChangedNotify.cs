using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BB5 RID: 2997
	[NetMessage(EMessageId.PackAnimChangedNotify)]
	public sealed class PackAnimChangedNotify : IMessage<PackAnimChangedNotify>, IMessage, IEquatable<PackAnimChangedNotify>, IDeepCloneable<PackAnimChangedNotify>, IBufferMessage
	{
		// Token: 0x060103F1 RID: 66545 RVA: 0x0025F174 File Offset: 0x0025D374
		[NullableContext(1)]
		public static PackAnimChangedNotify Create()
		{
			return new PackAnimChangedNotify();
		}

		// Token: 0x17003548 RID: 13640
		// (get) Token: 0x060103F2 RID: 66546 RVA: 0x0025F17B File Offset: 0x0025D37B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003549 RID: 13641
		// (get) Token: 0x060103F3 RID: 66547 RVA: 0x0025F17E File Offset: 0x0025D37E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PackAnimChangedNotify.Descriptor;
			}
		}

		// Token: 0x060103F4 RID: 66548 RVA: 0x0025F185 File Offset: 0x0025D385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PackAnimChangedNotify()
		{
		}

		// Token: 0x060103F5 RID: 66549 RVA: 0x0025F198 File Offset: 0x0025D398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PackAnimChangedNotify(PackAnimChangedNotify other) : this()
		{
			this.entityAnimState_ = other.entityAnimState_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060103F6 RID: 66550 RVA: 0x0025F1C2 File Offset: 0x0025D3C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PackAnimChangedNotify Clone()
		{
			return new PackAnimChangedNotify(this);
		}

		// Token: 0x1700354A RID: 13642
		// (get) Token: 0x060103F7 RID: 66551 RVA: 0x0025F1CA File Offset: 0x0025D3CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AnimStateChangeInfoList> EntityAnimState
		{
			get
			{
				return this.entityAnimState_;
			}
		}

		// Token: 0x060103F8 RID: 66552 RVA: 0x0025F1D2 File Offset: 0x0025D3D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PackAnimChangedNotify);
		}

		// Token: 0x060103F9 RID: 66553 RVA: 0x0025F1E0 File Offset: 0x0025D3E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PackAnimChangedNotify other)
		{
			return other != null && (other == this || (this.entityAnimState_.Equals(other.entityAnimState_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060103FA RID: 66554 RVA: 0x0025F214 File Offset: 0x0025D414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.entityAnimState_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060103FB RID: 66555 RVA: 0x0025F248 File Offset: 0x0025D448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060103FC RID: 66556 RVA: 0x0025F255 File Offset: 0x0025D455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060103FD RID: 66557 RVA: 0x0025F25E File Offset: 0x0025D45E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityAnimState_.WriteTo(ref output, PackAnimChangedNotify._repeated_entityAnimState_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060103FE RID: 66558 RVA: 0x0025F288 File Offset: 0x0025D488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entityAnimState_.CalculateSize(PackAnimChangedNotify._repeated_entityAnimState_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060103FF RID: 66559 RVA: 0x0025F2C1 File Offset: 0x0025D4C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PackAnimChangedNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.entityAnimState_.Add(other.entityAnimState_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010400 RID: 66560 RVA: 0x0025F2EF File Offset: 0x0025D4EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010401 RID: 66561 RVA: 0x0025F2F8 File Offset: 0x0025D4F8
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.entityAnimState_.AddEntriesFrom(ref input, PackAnimChangedNotify._repeated_entityAnimState_codec);
				}
			}
		}

		// Token: 0x04006764 RID: 26468
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006765 RID: 26469
		public const int EntityAnimStateFieldNumber = 2;

		// Token: 0x04006766 RID: 26470
		private static readonly FieldCodec<AnimStateChangeInfoList> _repeated_entityAnimState_codec = FieldCodec.ForMessage<AnimStateChangeInfoList>(18U, AnimStateChangeInfoList.Parser);

		// Token: 0x04006767 RID: 26471
		private readonly RepeatedField<AnimStateChangeInfoList> entityAnimState_ = new RepeatedField<AnimStateChangeInfoList>();
	}
}
