using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000076 RID: 118
	[NetMessage(EMessageId.ActionRelatedEntityInfoNotify)]
	public sealed class ActionRelatedEntityInfoNotify : IMessage<ActionRelatedEntityInfoNotify>, IMessage, IEquatable<ActionRelatedEntityInfoNotify>, IDeepCloneable<ActionRelatedEntityInfoNotify>, IBufferMessage
	{
		// Token: 0x060017EE RID: 6126 RVA: 0x0003ED85 File Offset: 0x0003CF85
		[NullableContext(1)]
		public static ActionRelatedEntityInfoNotify Create()
		{
			return new ActionRelatedEntityInfoNotify();
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060017EF RID: 6127 RVA: 0x0003ED8C File Offset: 0x0003CF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060017F0 RID: 6128 RVA: 0x0003ED8F File Offset: 0x0003CF8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActionRelatedEntityInfoNotify.Descriptor;
			}
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x0003ED96 File Offset: 0x0003CF96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionRelatedEntityInfoNotify()
		{
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x0003EDB4 File Offset: 0x0003CFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionRelatedEntityInfoNotify(ActionRelatedEntityInfoNotify other) : this()
		{
			this.entityStateChangeResult_ = other.entityStateChangeResult_.Clone();
			this.entityDestroyResult_ = other.entityDestroyResult_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x0003EDEF File Offset: 0x0003CFEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionRelatedEntityInfoNotify Clone()
		{
			return new ActionRelatedEntityInfoNotify(this);
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060017F4 RID: 6132 RVA: 0x0003EDF7 File Offset: 0x0003CFF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntityStateChangeResult> EntityStateChangeResult
		{
			get
			{
				return this.entityStateChangeResult_;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060017F5 RID: 6133 RVA: 0x0003EDFF File Offset: 0x0003CFFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntityDestroyResult> EntityDestroyResult
		{
			get
			{
				return this.entityDestroyResult_;
			}
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x0003EE07 File Offset: 0x0003D007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActionRelatedEntityInfoNotify);
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x0003EE18 File Offset: 0x0003D018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActionRelatedEntityInfoNotify other)
		{
			return other != null && (other == this || (this.entityStateChangeResult_.Equals(other.entityStateChangeResult_) && this.entityDestroyResult_.Equals(other.entityDestroyResult_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x0003EE6C File Offset: 0x0003D06C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.entityStateChangeResult_.GetHashCode();
			num ^= this.entityDestroyResult_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x0003EEAE File Offset: 0x0003D0AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x0003EEBB File Offset: 0x0003D0BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x0003EEC4 File Offset: 0x0003D0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityStateChangeResult_.WriteTo(ref output, ActionRelatedEntityInfoNotify._repeated_entityStateChangeResult_codec);
			this.entityDestroyResult_.WriteTo(ref output, ActionRelatedEntityInfoNotify._repeated_entityDestroyResult_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x0003EEFC File Offset: 0x0003D0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entityStateChangeResult_.CalculateSize(ActionRelatedEntityInfoNotify._repeated_entityStateChangeResult_codec);
			num += this.entityDestroyResult_.CalculateSize(ActionRelatedEntityInfoNotify._repeated_entityDestroyResult_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x0003EF48 File Offset: 0x0003D148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActionRelatedEntityInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.entityStateChangeResult_.Add(other.entityStateChangeResult_);
			this.entityDestroyResult_.Add(other.entityDestroyResult_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x0003EF87 File Offset: 0x0003D187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x0003EF90 File Offset: 0x0003D190
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
				if (num != 26U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.entityDestroyResult_.AddEntriesFrom(ref input, ActionRelatedEntityInfoNotify._repeated_entityDestroyResult_codec);
					}
				}
				else
				{
					this.entityStateChangeResult_.AddEntriesFrom(ref input, ActionRelatedEntityInfoNotify._repeated_entityStateChangeResult_codec);
				}
			}
		}

		// Token: 0x04002157 RID: 8535
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002158 RID: 8536
		public const int EntityStateChangeResultFieldNumber = 3;

		// Token: 0x04002159 RID: 8537
		private static readonly FieldCodec<EntityStateChangeResult> _repeated_entityStateChangeResult_codec = FieldCodec.ForMessage<EntityStateChangeResult>(26U, Aki.Protocol.EntityStateChangeResult.Parser);

		// Token: 0x0400215A RID: 8538
		private readonly RepeatedField<EntityStateChangeResult> entityStateChangeResult_ = new RepeatedField<EntityStateChangeResult>();

		// Token: 0x0400215B RID: 8539
		public const int EntityDestroyResultFieldNumber = 15;

		// Token: 0x0400215C RID: 8540
		private static readonly FieldCodec<EntityDestroyResult> _repeated_entityDestroyResult_codec = FieldCodec.ForMessage<EntityDestroyResult>(122U, Aki.Protocol.EntityDestroyResult.Parser);

		// Token: 0x0400215D RID: 8541
		private readonly RepeatedField<EntityDestroyResult> entityDestroyResult_ = new RepeatedField<EntityDestroyResult>();
	}
}
