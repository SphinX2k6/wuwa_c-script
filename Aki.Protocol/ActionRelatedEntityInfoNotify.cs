using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000077 RID: 119
	[NetMessage(EMessageId.ActionRelatedEntityInfoNotify)]
	public sealed class ActionRelatedEntityInfoNotify : IMessage<ActionRelatedEntityInfoNotify>, IMessage, IEquatable<ActionRelatedEntityInfoNotify>, IDeepCloneable<ActionRelatedEntityInfoNotify>, IBufferMessage
	{
		// Token: 0x06001831 RID: 6193 RVA: 0x0003F729 File Offset: 0x0003D929
		[NullableContext(1)]
		public static ActionRelatedEntityInfoNotify Create()
		{
			return new ActionRelatedEntityInfoNotify();
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06001832 RID: 6194 RVA: 0x0003F730 File Offset: 0x0003D930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06001833 RID: 6195 RVA: 0x0003F733 File Offset: 0x0003D933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActionRelatedEntityInfoNotify.Descriptor;
			}
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x0003F73A File Offset: 0x0003D93A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionRelatedEntityInfoNotify()
		{
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x0003F758 File Offset: 0x0003D958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionRelatedEntityInfoNotify(ActionRelatedEntityInfoNotify other) : this()
		{
			this.entityStateChangeResult_ = other.entityStateChangeResult_.Clone();
			this.entityDestroyResult_ = other.entityDestroyResult_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x0003F793 File Offset: 0x0003D993
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionRelatedEntityInfoNotify Clone()
		{
			return new ActionRelatedEntityInfoNotify(this);
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06001837 RID: 6199 RVA: 0x0003F79B File Offset: 0x0003D99B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntityStateChangeResult> EntityStateChangeResult
		{
			get
			{
				return this.entityStateChangeResult_;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06001838 RID: 6200 RVA: 0x0003F7A3 File Offset: 0x0003D9A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntityDestroyResult> EntityDestroyResult
		{
			get
			{
				return this.entityDestroyResult_;
			}
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x0003F7AB File Offset: 0x0003D9AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActionRelatedEntityInfoNotify);
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x0003F7BC File Offset: 0x0003D9BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActionRelatedEntityInfoNotify other)
		{
			return other != null && (other == this || (this.entityStateChangeResult_.Equals(other.entityStateChangeResult_) && this.entityDestroyResult_.Equals(other.entityDestroyResult_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x0003F810 File Offset: 0x0003DA10
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

		// Token: 0x0600183C RID: 6204 RVA: 0x0003F852 File Offset: 0x0003DA52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x0003F85F File Offset: 0x0003DA5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x0003F868 File Offset: 0x0003DA68
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

		// Token: 0x0600183F RID: 6207 RVA: 0x0003F8A0 File Offset: 0x0003DAA0
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

		// Token: 0x06001840 RID: 6208 RVA: 0x0003F8EC File Offset: 0x0003DAEC
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

		// Token: 0x06001841 RID: 6209 RVA: 0x0003F92B File Offset: 0x0003DB2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x0003F934 File Offset: 0x0003DB34
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
					if (num != 66U)
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

		// Token: 0x040021B6 RID: 8630
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021B7 RID: 8631
		public const int EntityStateChangeResultFieldNumber = 1;

		// Token: 0x040021B8 RID: 8632
		private static readonly FieldCodec<EntityStateChangeResult> _repeated_entityStateChangeResult_codec = FieldCodec.ForMessage<EntityStateChangeResult>(10U, Aki.Protocol.EntityStateChangeResult.Parser);

		// Token: 0x040021B9 RID: 8633
		private readonly RepeatedField<EntityStateChangeResult> entityStateChangeResult_ = new RepeatedField<EntityStateChangeResult>();

		// Token: 0x040021BA RID: 8634
		public const int EntityDestroyResultFieldNumber = 8;

		// Token: 0x040021BB RID: 8635
		private static readonly FieldCodec<EntityDestroyResult> _repeated_entityDestroyResult_codec = FieldCodec.ForMessage<EntityDestroyResult>(66U, Aki.Protocol.EntityDestroyResult.Parser);

		// Token: 0x040021BC RID: 8636
		private readonly RepeatedField<EntityDestroyResult> entityDestroyResult_ = new RepeatedField<EntityDestroyResult>();
	}
}
