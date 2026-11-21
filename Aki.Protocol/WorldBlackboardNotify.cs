using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200158B RID: 5515
	[NetMessage(EMessageId.WorldBlackboardNotify)]
	public sealed class WorldBlackboardNotify : IMessage<WorldBlackboardNotify>, IMessage, IEquatable<WorldBlackboardNotify>, IDeepCloneable<WorldBlackboardNotify>, IBufferMessage
	{
		// Token: 0x0601D31E RID: 119582 RVA: 0x0043A11A File Offset: 0x0043831A
		[NullableContext(1)]
		public static WorldBlackboardNotify Create()
		{
			return new WorldBlackboardNotify();
		}

		// Token: 0x170062C5 RID: 25285
		// (get) Token: 0x0601D31F RID: 119583 RVA: 0x0043A121 File Offset: 0x00438321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062C6 RID: 25286
		// (get) Token: 0x0601D320 RID: 119584 RVA: 0x0043A124 File Offset: 0x00438324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorldBlackboardNotify.Descriptor;
			}
		}

		// Token: 0x0601D321 RID: 119585 RVA: 0x0043A12B File Offset: 0x0043832B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldBlackboardNotify()
		{
		}

		// Token: 0x0601D322 RID: 119586 RVA: 0x0043A13E File Offset: 0x0043833E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldBlackboardNotify(WorldBlackboardNotify other) : this()
		{
			this.params_ = other.params_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D323 RID: 119587 RVA: 0x0043A168 File Offset: 0x00438368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldBlackboardNotify Clone()
		{
			return new WorldBlackboardNotify(this);
		}

		// Token: 0x170062C7 RID: 25287
		// (get) Token: 0x0601D324 RID: 119588 RVA: 0x0043A170 File Offset: 0x00438370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BlackboardParam> Params
		{
			get
			{
				return this.params_;
			}
		}

		// Token: 0x0601D325 RID: 119589 RVA: 0x0043A178 File Offset: 0x00438378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorldBlackboardNotify);
		}

		// Token: 0x0601D326 RID: 119590 RVA: 0x0043A186 File Offset: 0x00438386
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorldBlackboardNotify other)
		{
			return other != null && (other == this || (this.params_.Equals(other.params_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D327 RID: 119591 RVA: 0x0043A1BC File Offset: 0x004383BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.params_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D328 RID: 119592 RVA: 0x0043A1F0 File Offset: 0x004383F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D329 RID: 119593 RVA: 0x0043A1FD File Offset: 0x004383FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D32A RID: 119594 RVA: 0x0043A206 File Offset: 0x00438406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.params_.WriteTo(ref output, WorldBlackboardNotify._repeated_params_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D32B RID: 119595 RVA: 0x0043A230 File Offset: 0x00438430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.params_.CalculateSize(WorldBlackboardNotify._repeated_params_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D32C RID: 119596 RVA: 0x0043A269 File Offset: 0x00438469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WorldBlackboardNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.params_.Add(other.params_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D32D RID: 119597 RVA: 0x0043A297 File Offset: 0x00438497
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D32E RID: 119598 RVA: 0x0043A2A0 File Offset: 0x004384A0
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
					this.params_.AddEntriesFrom(ref input, WorldBlackboardNotify._repeated_params_codec);
				}
			}
		}

		// Token: 0x0400A783 RID: 42883
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A784 RID: 42884
		public const int ParamsFieldNumber = 7;

		// Token: 0x0400A785 RID: 42885
		private static readonly FieldCodec<BlackboardParam> _repeated_params_codec = FieldCodec.ForMessage<BlackboardParam>(58U, BlackboardParam.Parser);

		// Token: 0x0400A786 RID: 42886
		private readonly RepeatedField<BlackboardParam> params_ = new RepeatedField<BlackboardParam>();
	}
}
