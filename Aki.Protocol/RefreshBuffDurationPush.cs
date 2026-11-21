using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EC7 RID: 3783
	[NetMessage(EMessageId.RefreshBuffDurationPush)]
	public sealed class RefreshBuffDurationPush : IMessage<RefreshBuffDurationPush>, IMessage, IEquatable<RefreshBuffDurationPush>, IDeepCloneable<RefreshBuffDurationPush>, IBufferMessage
	{
		// Token: 0x060144EC RID: 83180 RVA: 0x002F40DC File Offset: 0x002F22DC
		[NullableContext(1)]
		public static RefreshBuffDurationPush Create()
		{
			return new RefreshBuffDurationPush();
		}

		// Token: 0x17004388 RID: 17288
		// (get) Token: 0x060144ED RID: 83181 RVA: 0x002F40E3 File Offset: 0x002F22E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004389 RID: 17289
		// (get) Token: 0x060144EE RID: 83182 RVA: 0x002F40E6 File Offset: 0x002F22E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RefreshBuffDurationPush.Descriptor;
			}
		}

		// Token: 0x060144EF RID: 83183 RVA: 0x002F40ED File Offset: 0x002F22ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RefreshBuffDurationPush()
		{
		}

		// Token: 0x060144F0 RID: 83184 RVA: 0x002F4100 File Offset: 0x002F2300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RefreshBuffDurationPush(RefreshBuffDurationPush other) : this()
		{
			this.buffIds_ = other.buffIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060144F1 RID: 83185 RVA: 0x002F412A File Offset: 0x002F232A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RefreshBuffDurationPush Clone()
		{
			return new RefreshBuffDurationPush(this);
		}

		// Token: 0x1700438A RID: 17290
		// (get) Token: 0x060144F2 RID: 83186 RVA: 0x002F4132 File Offset: 0x002F2332
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> BuffIds
		{
			get
			{
				return this.buffIds_;
			}
		}

		// Token: 0x060144F3 RID: 83187 RVA: 0x002F413A File Offset: 0x002F233A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RefreshBuffDurationPush);
		}

		// Token: 0x060144F4 RID: 83188 RVA: 0x002F4148 File Offset: 0x002F2348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RefreshBuffDurationPush other)
		{
			return other != null && (other == this || (this.buffIds_.Equals(other.buffIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060144F5 RID: 83189 RVA: 0x002F417C File Offset: 0x002F237C
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

		// Token: 0x060144F6 RID: 83190 RVA: 0x002F41B0 File Offset: 0x002F23B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060144F7 RID: 83191 RVA: 0x002F41BD File Offset: 0x002F23BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060144F8 RID: 83192 RVA: 0x002F41C6 File Offset: 0x002F23C6
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

		// Token: 0x060144F9 RID: 83193 RVA: 0x002F41F0 File Offset: 0x002F23F0
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

		// Token: 0x060144FA RID: 83194 RVA: 0x002F4229 File Offset: 0x002F2429
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

		// Token: 0x060144FB RID: 83195 RVA: 0x002F4257 File Offset: 0x002F2457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060144FC RID: 83196 RVA: 0x002F4260 File Offset: 0x002F2460
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
				if (num != 32U && num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.buffIds_.AddEntriesFrom(ref input, RefreshBuffDurationPush._repeated_buffIds_codec);
				}
			}
		}

		// Token: 0x04007BC6 RID: 31686
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007BC7 RID: 31687
		public const int BuffIdsFieldNumber = 4;

		// Token: 0x04007BC8 RID: 31688
		private static readonly FieldCodec<long> _repeated_buffIds_codec = FieldCodec.ForInt64(34U);

		// Token: 0x04007BC9 RID: 31689
		private readonly RepeatedField<long> buffIds_ = new RepeatedField<long>();
	}
}
