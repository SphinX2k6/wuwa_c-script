using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001455 RID: 5205
	[NetMessage(EMessageId.TrapDefenseSystemInfoUpdateNotify)]
	public sealed class TrapDefenseSystemInfoUpdateNotify : IMessage<TrapDefenseSystemInfoUpdateNotify>, IMessage, IEquatable<TrapDefenseSystemInfoUpdateNotify>, IDeepCloneable<TrapDefenseSystemInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601B908 RID: 112904 RVA: 0x003FD9DF File Offset: 0x003FBBDF
		[NullableContext(1)]
		public static TrapDefenseSystemInfoUpdateNotify Create()
		{
			return new TrapDefenseSystemInfoUpdateNotify();
		}

		// Token: 0x17005CF4 RID: 23796
		// (get) Token: 0x0601B909 RID: 112905 RVA: 0x003FD9E6 File Offset: 0x003FBBE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CF5 RID: 23797
		// (get) Token: 0x0601B90A RID: 112906 RVA: 0x003FD9E9 File Offset: 0x003FBBE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseSystemInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601B90B RID: 112907 RVA: 0x003FD9F0 File Offset: 0x003FBBF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSystemInfoUpdateNotify()
		{
		}

		// Token: 0x0601B90C RID: 112908 RVA: 0x003FDA03 File Offset: 0x003FBC03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSystemInfoUpdateNotify(TrapDefenseSystemInfoUpdateNotify other) : this()
		{
			this.slots_ = other.slots_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B90D RID: 112909 RVA: 0x003FDA2D File Offset: 0x003FBC2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSystemInfoUpdateNotify Clone()
		{
			return new TrapDefenseSystemInfoUpdateNotify(this);
		}

		// Token: 0x17005CF6 RID: 23798
		// (get) Token: 0x0601B90E RID: 112910 RVA: 0x003FDA35 File Offset: 0x003FBC35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseSlot> Slots
		{
			get
			{
				return this.slots_;
			}
		}

		// Token: 0x0601B90F RID: 112911 RVA: 0x003FDA3D File Offset: 0x003FBC3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseSystemInfoUpdateNotify);
		}

		// Token: 0x0601B910 RID: 112912 RVA: 0x003FDA4B File Offset: 0x003FBC4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseSystemInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.slots_.Equals(other.slots_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B911 RID: 112913 RVA: 0x003FDA80 File Offset: 0x003FBC80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.slots_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B912 RID: 112914 RVA: 0x003FDAB4 File Offset: 0x003FBCB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B913 RID: 112915 RVA: 0x003FDAC1 File Offset: 0x003FBCC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B914 RID: 112916 RVA: 0x003FDACA File Offset: 0x003FBCCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.slots_.WriteTo(ref output, TrapDefenseSystemInfoUpdateNotify._repeated_slots_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B915 RID: 112917 RVA: 0x003FDAF4 File Offset: 0x003FBCF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.slots_.CalculateSize(TrapDefenseSystemInfoUpdateNotify._repeated_slots_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B916 RID: 112918 RVA: 0x003FDB2D File Offset: 0x003FBD2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseSystemInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.slots_.Add(other.slots_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B917 RID: 112919 RVA: 0x003FDB5B File Offset: 0x003FBD5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B918 RID: 112920 RVA: 0x003FDB64 File Offset: 0x003FBD64
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.slots_.AddEntriesFrom(ref input, TrapDefenseSystemInfoUpdateNotify._repeated_slots_codec);
				}
			}
		}

		// Token: 0x04009EEE RID: 40686
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009EEF RID: 40687
		public const int SlotsFieldNumber = 12;

		// Token: 0x04009EF0 RID: 40688
		private static readonly FieldCodec<TrapDefenseSlot> _repeated_slots_codec = FieldCodec.ForMessage<TrapDefenseSlot>(98U, TrapDefenseSlot.Parser);

		// Token: 0x04009EF1 RID: 40689
		private readonly RepeatedField<TrapDefenseSlot> slots_ = new RepeatedField<TrapDefenseSlot>();
	}
}
