using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BA5 RID: 2981
	[NetMessage(EMessageId.PackAnimChangedNotify)]
	public sealed class PackAnimChangedNotify : IMessage<PackAnimChangedNotify>, IMessage, IEquatable<PackAnimChangedNotify>, IDeepCloneable<PackAnimChangedNotify>, IBufferMessage
	{
		// Token: 0x060102ED RID: 66285 RVA: 0x0025D2C0 File Offset: 0x0025B4C0
		[NullableContext(1)]
		public static PackAnimChangedNotify Create()
		{
			return new PackAnimChangedNotify();
		}

		// Token: 0x1700350F RID: 13583
		// (get) Token: 0x060102EE RID: 66286 RVA: 0x0025D2C7 File Offset: 0x0025B4C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003510 RID: 13584
		// (get) Token: 0x060102EF RID: 66287 RVA: 0x0025D2CA File Offset: 0x0025B4CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PackAnimChangedNotify.Descriptor;
			}
		}

		// Token: 0x060102F0 RID: 66288 RVA: 0x0025D2D1 File Offset: 0x0025B4D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PackAnimChangedNotify()
		{
		}

		// Token: 0x060102F1 RID: 66289 RVA: 0x0025D2E4 File Offset: 0x0025B4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PackAnimChangedNotify(PackAnimChangedNotify other) : this()
		{
			this.entityAnimState_ = other.entityAnimState_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060102F2 RID: 66290 RVA: 0x0025D30E File Offset: 0x0025B50E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PackAnimChangedNotify Clone()
		{
			return new PackAnimChangedNotify(this);
		}

		// Token: 0x17003511 RID: 13585
		// (get) Token: 0x060102F3 RID: 66291 RVA: 0x0025D316 File Offset: 0x0025B516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AnimStateChangeInfoList> EntityAnimState
		{
			get
			{
				return this.entityAnimState_;
			}
		}

		// Token: 0x060102F4 RID: 66292 RVA: 0x0025D31E File Offset: 0x0025B51E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PackAnimChangedNotify);
		}

		// Token: 0x060102F5 RID: 66293 RVA: 0x0025D32C File Offset: 0x0025B52C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PackAnimChangedNotify other)
		{
			return other != null && (other == this || (this.entityAnimState_.Equals(other.entityAnimState_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060102F6 RID: 66294 RVA: 0x0025D360 File Offset: 0x0025B560
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

		// Token: 0x060102F7 RID: 66295 RVA: 0x0025D394 File Offset: 0x0025B594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060102F8 RID: 66296 RVA: 0x0025D3A1 File Offset: 0x0025B5A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060102F9 RID: 66297 RVA: 0x0025D3AA File Offset: 0x0025B5AA
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

		// Token: 0x060102FA RID: 66298 RVA: 0x0025D3D4 File Offset: 0x0025B5D4
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

		// Token: 0x060102FB RID: 66299 RVA: 0x0025D40D File Offset: 0x0025B60D
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

		// Token: 0x060102FC RID: 66300 RVA: 0x0025D43B File Offset: 0x0025B63B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060102FD RID: 66301 RVA: 0x0025D444 File Offset: 0x0025B644
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.entityAnimState_.AddEntriesFrom(ref input, PackAnimChangedNotify._repeated_entityAnimState_codec);
				}
			}
		}

		// Token: 0x04006774 RID: 26484
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006775 RID: 26485
		public const int EntityAnimStateFieldNumber = 1;

		// Token: 0x04006776 RID: 26486
		private static readonly FieldCodec<AnimStateChangeInfoList> _repeated_entityAnimState_codec = FieldCodec.ForMessage<AnimStateChangeInfoList>(10U, AnimStateChangeInfoList.Parser);

		// Token: 0x04006777 RID: 26487
		private readonly RepeatedField<AnimStateChangeInfoList> entityAnimState_ = new RepeatedField<AnimStateChangeInfoList>();
	}
}
