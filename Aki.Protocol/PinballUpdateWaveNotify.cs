using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D6A RID: 3434
	[NetMessage(EMessageId.PinballUpdateWaveNotify)]
	public sealed class PinballUpdateWaveNotify : IMessage<PinballUpdateWaveNotify>, IMessage, IEquatable<PinballUpdateWaveNotify>, IDeepCloneable<PinballUpdateWaveNotify>, IBufferMessage
	{
		// Token: 0x06012840 RID: 75840 RVA: 0x002B38AB File Offset: 0x002B1AAB
		[NullableContext(1)]
		public static PinballUpdateWaveNotify Create()
		{
			return new PinballUpdateWaveNotify();
		}

		// Token: 0x17003D5F RID: 15711
		// (get) Token: 0x06012841 RID: 75841 RVA: 0x002B38B2 File Offset: 0x002B1AB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D60 RID: 15712
		// (get) Token: 0x06012842 RID: 75842 RVA: 0x002B38B5 File Offset: 0x002B1AB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballUpdateWaveNotify.Descriptor;
			}
		}

		// Token: 0x06012843 RID: 75843 RVA: 0x002B38BC File Offset: 0x002B1ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballUpdateWaveNotify()
		{
		}

		// Token: 0x06012844 RID: 75844 RVA: 0x002B38C4 File Offset: 0x002B1AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballUpdateWaveNotify(PinballUpdateWaveNotify other) : this()
		{
			this.waveId_ = other.waveId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012845 RID: 75845 RVA: 0x002B38E9 File Offset: 0x002B1AE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballUpdateWaveNotify Clone()
		{
			return new PinballUpdateWaveNotify(this);
		}

		// Token: 0x17003D61 RID: 15713
		// (get) Token: 0x06012846 RID: 75846 RVA: 0x002B38F1 File Offset: 0x002B1AF1
		// (set) Token: 0x06012847 RID: 75847 RVA: 0x002B38F9 File Offset: 0x002B1AF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WaveId
		{
			get
			{
				return this.waveId_;
			}
			set
			{
				this.waveId_ = value;
			}
		}

		// Token: 0x06012848 RID: 75848 RVA: 0x002B3902 File Offset: 0x002B1B02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballUpdateWaveNotify);
		}

		// Token: 0x06012849 RID: 75849 RVA: 0x002B3910 File Offset: 0x002B1B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballUpdateWaveNotify other)
		{
			return other != null && (other == this || (this.WaveId == other.WaveId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601284A RID: 75850 RVA: 0x002B3940 File Offset: 0x002B1B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WaveId != 0)
			{
				num ^= this.WaveId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601284B RID: 75851 RVA: 0x002B397F File Offset: 0x002B1B7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601284C RID: 75852 RVA: 0x002B398C File Offset: 0x002B1B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601284D RID: 75853 RVA: 0x002B3995 File Offset: 0x002B1B95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WaveId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.WaveId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601284E RID: 75854 RVA: 0x002B39C8 File Offset: 0x002B1BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WaveId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WaveId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601284F RID: 75855 RVA: 0x002B3A06 File Offset: 0x002B1C06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballUpdateWaveNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WaveId != 0)
			{
				this.WaveId = other.WaveId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012850 RID: 75856 RVA: 0x002B3A37 File Offset: 0x002B1C37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012851 RID: 75857 RVA: 0x002B3A40 File Offset: 0x002B1C40
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.WaveId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007310 RID: 29456
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007311 RID: 29457
		public const int WaveIdFieldNumber = 10;

		// Token: 0x04007312 RID: 29458
		private int waveId_;
	}
}
