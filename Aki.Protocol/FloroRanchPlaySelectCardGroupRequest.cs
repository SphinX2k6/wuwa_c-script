using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005CA RID: 1482
	[NetMessage(EMessageId.FloroRanchPlaySelectCardGroupRequest)]
	public sealed class FloroRanchPlaySelectCardGroupRequest : IMessage<FloroRanchPlaySelectCardGroupRequest>, IMessage, IEquatable<FloroRanchPlaySelectCardGroupRequest>, IDeepCloneable<FloroRanchPlaySelectCardGroupRequest>, IBufferMessage
	{
		// Token: 0x060088F0 RID: 35056 RVA: 0x00149F7D File Offset: 0x0014817D
		[NullableContext(1)]
		public static FloroRanchPlaySelectCardGroupRequest Create()
		{
			return new FloroRanchPlaySelectCardGroupRequest();
		}

		// Token: 0x17001ADE RID: 6878
		// (get) Token: 0x060088F1 RID: 35057 RVA: 0x00149F84 File Offset: 0x00148184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001ADF RID: 6879
		// (get) Token: 0x060088F2 RID: 35058 RVA: 0x00149F87 File Offset: 0x00148187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlaySelectCardGroupRequest.Descriptor;
			}
		}

		// Token: 0x060088F3 RID: 35059 RVA: 0x00149F8E File Offset: 0x0014818E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlaySelectCardGroupRequest()
		{
		}

		// Token: 0x060088F4 RID: 35060 RVA: 0x00149FA4 File Offset: 0x001481A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlaySelectCardGroupRequest(FloroRanchPlaySelectCardGroupRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this.cardId_ = other.cardId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060088F5 RID: 35061 RVA: 0x00149FF1 File Offset: 0x001481F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlaySelectCardGroupRequest Clone()
		{
			return new FloroRanchPlaySelectCardGroupRequest(this);
		}

		// Token: 0x17001AE0 RID: 6880
		// (get) Token: 0x060088F6 RID: 35062 RVA: 0x00149FF9 File Offset: 0x001481F9
		// (set) Token: 0x060088F7 RID: 35063 RVA: 0x0014A001 File Offset: 0x00148201
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17001AE1 RID: 6881
		// (get) Token: 0x060088F8 RID: 35064 RVA: 0x0014A00A File Offset: 0x0014820A
		// (set) Token: 0x060088F9 RID: 35065 RVA: 0x0014A012 File Offset: 0x00148212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubInsId
		{
			get
			{
				return this.subInsId_;
			}
			set
			{
				this.subInsId_ = value;
			}
		}

		// Token: 0x17001AE2 RID: 6882
		// (get) Token: 0x060088FA RID: 35066 RVA: 0x0014A01B File Offset: 0x0014821B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CardId
		{
			get
			{
				return this.cardId_;
			}
		}

		// Token: 0x060088FB RID: 35067 RVA: 0x0014A023 File Offset: 0x00148223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlaySelectCardGroupRequest);
		}

		// Token: 0x060088FC RID: 35068 RVA: 0x0014A034 File Offset: 0x00148234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlaySelectCardGroupRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && this.cardId_.Equals(other.cardId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060088FD RID: 35069 RVA: 0x0014A094 File Offset: 0x00148294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.SubInsId != 0)
			{
				num ^= this.SubInsId.GetHashCode();
			}
			num ^= this.cardId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060088FE RID: 35070 RVA: 0x0014A0FA File Offset: 0x001482FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060088FF RID: 35071 RVA: 0x0014A107 File Offset: 0x00148307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008900 RID: 35072 RVA: 0x0014A110 File Offset: 0x00148310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SubInsId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActivityId);
			}
			this.cardId_.WriteTo(ref output, FloroRanchPlaySelectCardGroupRequest._repeated_cardId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008901 RID: 35073 RVA: 0x0014A17C File Offset: 0x0014837C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.SubInsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubInsId);
			}
			num += this.cardId_.CalculateSize(FloroRanchPlaySelectCardGroupRequest._repeated_cardId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008902 RID: 35074 RVA: 0x0014A1E8 File Offset: 0x001483E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlaySelectCardGroupRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.SubInsId != 0)
			{
				this.SubInsId = other.SubInsId;
			}
			this.cardId_.Add(other.cardId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008903 RID: 35075 RVA: 0x0014A249 File Offset: 0x00148449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008904 RID: 35076 RVA: 0x0014A254 File Offset: 0x00148454
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
				if (num <= 104U)
				{
					if (num == 16U)
					{
						this.SubInsId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				else if (num == 112U || num == 114U)
				{
					this.cardId_.AddEntriesFrom(ref input, FloroRanchPlaySelectCardGroupRequest._repeated_cardId_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400435A RID: 17242
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400435B RID: 17243
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x0400435C RID: 17244
		private int activityId_;

		// Token: 0x0400435D RID: 17245
		public const int SubInsIdFieldNumber = 2;

		// Token: 0x0400435E RID: 17246
		private int subInsId_;

		// Token: 0x0400435F RID: 17247
		public const int CardIdFieldNumber = 14;

		// Token: 0x04004360 RID: 17248
		private static readonly FieldCodec<int> _repeated_cardId_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04004361 RID: 17249
		private readonly RepeatedField<int> cardId_ = new RepeatedField<int>();
	}
}
