using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000253 RID: 595
	public sealed class ChangeEventByPosOp : IMessage<ChangeEventByPosOp>, IMessage, IEquatable<ChangeEventByPosOp>, IDeepCloneable<ChangeEventByPosOp>, IBufferMessage
	{
		// Token: 0x06003F9C RID: 16284 RVA: 0x0009CE89 File Offset: 0x0009B089
		[NullableContext(1)]
		public static ChangeEventByPosOp Create()
		{
			return new ChangeEventByPosOp();
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x06003F9D RID: 16285 RVA: 0x0009CE90 File Offset: 0x0009B090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x06003F9E RID: 16286 RVA: 0x0009CE93 File Offset: 0x0009B093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeEventByPosOp.Descriptor;
			}
		}

		// Token: 0x06003F9F RID: 16287 RVA: 0x0009CE9A File Offset: 0x0009B09A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEventByPosOp()
		{
		}

		// Token: 0x06003FA0 RID: 16288 RVA: 0x0009CEAD File Offset: 0x0009B0AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEventByPosOp(ChangeEventByPosOp other) : this()
		{
			this.changeEventDatas_ = other.changeEventDatas_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003FA1 RID: 16289 RVA: 0x0009CED7 File Offset: 0x0009B0D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEventByPosOp Clone()
		{
			return new ChangeEventByPosOp(this);
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06003FA2 RID: 16290 RVA: 0x0009CEDF File Offset: 0x0009B0DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ChangeEventData> ChangeEventDatas
		{
			get
			{
				return this.changeEventDatas_;
			}
		}

		// Token: 0x06003FA3 RID: 16291 RVA: 0x0009CEE7 File Offset: 0x0009B0E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeEventByPosOp);
		}

		// Token: 0x06003FA4 RID: 16292 RVA: 0x0009CEF5 File Offset: 0x0009B0F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeEventByPosOp other)
		{
			return other != null && (other == this || (this.changeEventDatas_.Equals(other.changeEventDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003FA5 RID: 16293 RVA: 0x0009CF28 File Offset: 0x0009B128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.changeEventDatas_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003FA6 RID: 16294 RVA: 0x0009CF5C File Offset: 0x0009B15C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003FA7 RID: 16295 RVA: 0x0009CF69 File Offset: 0x0009B169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003FA8 RID: 16296 RVA: 0x0009CF72 File Offset: 0x0009B172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.changeEventDatas_.WriteTo(ref output, ChangeEventByPosOp._repeated_changeEventDatas_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003FA9 RID: 16297 RVA: 0x0009CF9C File Offset: 0x0009B19C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.changeEventDatas_.CalculateSize(ChangeEventByPosOp._repeated_changeEventDatas_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003FAA RID: 16298 RVA: 0x0009CFD5 File Offset: 0x0009B1D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeEventByPosOp other)
		{
			if (other == null)
			{
				return;
			}
			this.changeEventDatas_.Add(other.changeEventDatas_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003FAB RID: 16299 RVA: 0x0009D003 File Offset: 0x0009B203
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003FAC RID: 16300 RVA: 0x0009D00C File Offset: 0x0009B20C
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
					this.changeEventDatas_.AddEntriesFrom(ref input, ChangeEventByPosOp._repeated_changeEventDatas_codec);
				}
			}
		}

		// Token: 0x04002D84 RID: 11652
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D85 RID: 11653
		public const int ChangeEventDatasFieldNumber = 1;

		// Token: 0x04002D86 RID: 11654
		private static readonly FieldCodec<ChangeEventData> _repeated_changeEventDatas_codec = FieldCodec.ForMessage<ChangeEventData>(10U, ChangeEventData.Parser);

		// Token: 0x04002D87 RID: 11655
		private readonly RepeatedField<ChangeEventData> changeEventDatas_ = new RepeatedField<ChangeEventData>();
	}
}
