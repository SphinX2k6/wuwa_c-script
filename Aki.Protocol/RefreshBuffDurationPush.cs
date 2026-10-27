using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ED7 RID: 3799
	[NetMessage(EMessageId.RefreshBuffDurationPush)]
	public sealed class RefreshBuffDurationPush : IMessage<RefreshBuffDurationPush>, IMessage, IEquatable<RefreshBuffDurationPush>, IDeepCloneable<RefreshBuffDurationPush>, IBufferMessage
	{
		// Token: 0x060145D1 RID: 83409 RVA: 0x002F5790 File Offset: 0x002F3990
		[NullableContext(1)]
		public static RefreshBuffDurationPush Create()
		{
			return new RefreshBuffDurationPush();
		}

		// Token: 0x170043B2 RID: 17330
		// (get) Token: 0x060145D2 RID: 83410 RVA: 0x002F5797 File Offset: 0x002F3997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043B3 RID: 17331
		// (get) Token: 0x060145D3 RID: 83411 RVA: 0x002F579A File Offset: 0x002F399A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RefreshBuffDurationPush.Descriptor;
			}
		}

		// Token: 0x060145D4 RID: 83412 RVA: 0x002F57A1 File Offset: 0x002F39A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RefreshBuffDurationPush()
		{
		}

		// Token: 0x060145D5 RID: 83413 RVA: 0x002F57B4 File Offset: 0x002F39B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RefreshBuffDurationPush(RefreshBuffDurationPush other) : this()
		{
			this.buffIds_ = other.buffIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060145D6 RID: 83414 RVA: 0x002F57DE File Offset: 0x002F39DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RefreshBuffDurationPush Clone()
		{
			return new RefreshBuffDurationPush(this);
		}

		// Token: 0x170043B4 RID: 17332
		// (get) Token: 0x060145D7 RID: 83415 RVA: 0x002F57E6 File Offset: 0x002F39E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> BuffIds
		{
			get
			{
				return this.buffIds_;
			}
		}

		// Token: 0x060145D8 RID: 83416 RVA: 0x002F57EE File Offset: 0x002F39EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RefreshBuffDurationPush);
		}

		// Token: 0x060145D9 RID: 83417 RVA: 0x002F57FC File Offset: 0x002F39FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RefreshBuffDurationPush other)
		{
			return other != null && (other == this || (this.buffIds_.Equals(other.buffIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060145DA RID: 83418 RVA: 0x002F5830 File Offset: 0x002F3A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.buffIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060145DB RID: 83419 RVA: 0x002F5864 File Offset: 0x002F3A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060145DC RID: 83420 RVA: 0x002F5871 File Offset: 0x002F3A71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060145DD RID: 83421 RVA: 0x002F587A File Offset: 0x002F3A7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.buffIds_.WriteTo(ref output, RefreshBuffDurationPush._repeated_buffIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060145DE RID: 83422 RVA: 0x002F58A4 File Offset: 0x002F3AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.buffIds_.CalculateSize(RefreshBuffDurationPush._repeated_buffIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060145DF RID: 83423 RVA: 0x002F58DD File Offset: 0x002F3ADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RefreshBuffDurationPush other)
		{
			if (other == null)
			{
				return;
			}
			this.buffIds_.Add(other.buffIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060145E0 RID: 83424 RVA: 0x002F590B File Offset: 0x002F3B0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060145E1 RID: 83425 RVA: 0x002F5914 File Offset: 0x002F3B14
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
				if (num != 96U && num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.buffIds_.AddEntriesFrom(ref input, RefreshBuffDurationPush._repeated_buffIds_codec);
				}
			}
		}

		// Token: 0x04007B9C RID: 31644
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B9D RID: 31645
		public const int BuffIdsFieldNumber = 12;

		// Token: 0x04007B9E RID: 31646
		private static readonly FieldCodec<long> _repeated_buffIds_codec = FieldCodec.ForInt64(98U);

		// Token: 0x04007B9F RID: 31647
		private readonly RepeatedField<long> buffIds_ = new RepeatedField<long>();
	}
}
