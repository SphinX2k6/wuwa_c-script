using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005FA RID: 1530
	public sealed class FlowerPollutionComponentPb : IMessage<FlowerPollutionComponentPb>, IMessage, IEquatable<FlowerPollutionComponentPb>, IDeepCloneable<FlowerPollutionComponentPb>, IBufferMessage
	{
		// Token: 0x06008D9A RID: 36250 RVA: 0x00157641 File Offset: 0x00155841
		[NullableContext(1)]
		public static FlowerPollutionComponentPb Create()
		{
			return new FlowerPollutionComponentPb();
		}

		// Token: 0x17001C14 RID: 7188
		// (get) Token: 0x06008D9B RID: 36251 RVA: 0x00157648 File Offset: 0x00155848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C15 RID: 7189
		// (get) Token: 0x06008D9C RID: 36252 RVA: 0x0015764B File Offset: 0x0015584B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowerPollutionComponentPb.Descriptor;
			}
		}

		// Token: 0x06008D9D RID: 36253 RVA: 0x00157652 File Offset: 0x00155852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowerPollutionComponentPb()
		{
		}

		// Token: 0x06008D9E RID: 36254 RVA: 0x00157665 File Offset: 0x00155865
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowerPollutionComponentPb(FlowerPollutionComponentPb other) : this()
		{
			this.unPollutionSpline_ = other.unPollutionSpline_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008D9F RID: 36255 RVA: 0x0015768F File Offset: 0x0015588F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowerPollutionComponentPb Clone()
		{
			return new FlowerPollutionComponentPb(this);
		}

		// Token: 0x17001C16 RID: 7190
		// (get) Token: 0x06008DA0 RID: 36256 RVA: 0x00157697 File Offset: 0x00155897
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnPollutionSpline
		{
			get
			{
				return this.unPollutionSpline_;
			}
		}

		// Token: 0x06008DA1 RID: 36257 RVA: 0x0015769F File Offset: 0x0015589F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowerPollutionComponentPb);
		}

		// Token: 0x06008DA2 RID: 36258 RVA: 0x001576AD File Offset: 0x001558AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowerPollutionComponentPb other)
		{
			return other != null && (other == this || (this.unPollutionSpline_.Equals(other.unPollutionSpline_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008DA3 RID: 36259 RVA: 0x001576E0 File Offset: 0x001558E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unPollutionSpline_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008DA4 RID: 36260 RVA: 0x00157714 File Offset: 0x00155914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008DA5 RID: 36261 RVA: 0x00157721 File Offset: 0x00155921
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008DA6 RID: 36262 RVA: 0x0015772A File Offset: 0x0015592A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unPollutionSpline_.WriteTo(ref output, FlowerPollutionComponentPb._repeated_unPollutionSpline_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008DA7 RID: 36263 RVA: 0x00157754 File Offset: 0x00155954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unPollutionSpline_.CalculateSize(FlowerPollutionComponentPb._repeated_unPollutionSpline_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008DA8 RID: 36264 RVA: 0x0015778D File Offset: 0x0015598D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlowerPollutionComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			this.unPollutionSpline_.Add(other.unPollutionSpline_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008DA9 RID: 36265 RVA: 0x001577BB File Offset: 0x001559BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008DAA RID: 36266 RVA: 0x001577C4 File Offset: 0x001559C4
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
					this.unPollutionSpline_.AddEntriesFrom(ref input, FlowerPollutionComponentPb._repeated_unPollutionSpline_codec);
				}
			}
		}

		// Token: 0x0400451A RID: 17690
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400451B RID: 17691
		public const int UnPollutionSplineFieldNumber = 1;

		// Token: 0x0400451C RID: 17692
		private static readonly FieldCodec<int> _repeated_unPollutionSpline_codec = FieldCodec.ForInt32(10U);

		// Token: 0x0400451D RID: 17693
		private readonly RepeatedField<int> unPollutionSpline_ = new RepeatedField<int>();
	}
}
