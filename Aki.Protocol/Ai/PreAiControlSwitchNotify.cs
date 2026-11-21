using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x02001736 RID: 5942
	[NetMessage(EMessageId.PreAiControlSwitchNotify)]
	public sealed class PreAiControlSwitchNotify : IMessage<PreAiControlSwitchNotify>, IMessage, IEquatable<PreAiControlSwitchNotify>, IDeepCloneable<PreAiControlSwitchNotify>, IBufferMessage
	{
		// Token: 0x0601DD28 RID: 122152 RVA: 0x0045F403 File Offset: 0x0045D603
		[NullableContext(1)]
		public static PreAiControlSwitchNotify Create()
		{
			return new PreAiControlSwitchNotify();
		}

		// Token: 0x17006583 RID: 25987
		// (get) Token: 0x0601DD29 RID: 122153 RVA: 0x0045F40A File Offset: 0x0045D60A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006584 RID: 25988
		// (get) Token: 0x0601DD2A RID: 122154 RVA: 0x0045F40D File Offset: 0x0045D60D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PreAiControlSwitchNotify.Descriptor;
			}
		}

		// Token: 0x0601DD2B RID: 122155 RVA: 0x0045F414 File Offset: 0x0045D614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreAiControlSwitchNotify()
		{
		}

		// Token: 0x0601DD2C RID: 122156 RVA: 0x0045F427 File Offset: 0x0045D627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreAiControlSwitchNotify(PreAiControlSwitchNotify other) : this()
		{
			this.entityIds_ = other.entityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DD2D RID: 122157 RVA: 0x0045F451 File Offset: 0x0045D651
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreAiControlSwitchNotify Clone()
		{
			return new PreAiControlSwitchNotify(this);
		}

		// Token: 0x17006585 RID: 25989
		// (get) Token: 0x0601DD2E RID: 122158 RVA: 0x0045F459 File Offset: 0x0045D659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x0601DD2F RID: 122159 RVA: 0x0045F461 File Offset: 0x0045D661
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PreAiControlSwitchNotify);
		}

		// Token: 0x0601DD30 RID: 122160 RVA: 0x0045F46F File Offset: 0x0045D66F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PreAiControlSwitchNotify other)
		{
			return other != null && (other == this || (this.entityIds_.Equals(other.entityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DD31 RID: 122161 RVA: 0x0045F4A4 File Offset: 0x0045D6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.entityIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601DD32 RID: 122162 RVA: 0x0045F4D8 File Offset: 0x0045D6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DD33 RID: 122163 RVA: 0x0045F4E5 File Offset: 0x0045D6E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DD34 RID: 122164 RVA: 0x0045F4EE File Offset: 0x0045D6EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityIds_.WriteTo(ref output, PreAiControlSwitchNotify._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DD35 RID: 122165 RVA: 0x0045F518 File Offset: 0x0045D718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entityIds_.CalculateSize(PreAiControlSwitchNotify._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601DD36 RID: 122166 RVA: 0x0045F551 File Offset: 0x0045D751
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PreAiControlSwitchNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.entityIds_.Add(other.entityIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601DD37 RID: 122167 RVA: 0x0045F57F File Offset: 0x0045D77F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DD38 RID: 122168 RVA: 0x0045F588 File Offset: 0x0045D788
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.entityIds_.AddEntriesFrom(ref input, PreAiControlSwitchNotify._repeated_entityIds_codec);
				}
			}
		}

		// Token: 0x0400C9A1 RID: 51617
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C9A2 RID: 51618
		public const int EntityIdsFieldNumber = 1;

		// Token: 0x0400C9A3 RID: 51619
		private static readonly FieldCodec<long> _repeated_entityIds_codec = FieldCodec.ForInt64(10U);

		// Token: 0x0400C9A4 RID: 51620
		private readonly RepeatedField<long> entityIds_ = new RepeatedField<long>();
	}
}
