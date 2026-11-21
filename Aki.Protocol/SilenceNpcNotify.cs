using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001258 RID: 4696
	[NetMessage(EMessageId.SilenceNpcNotify)]
	public sealed class SilenceNpcNotify : IMessage<SilenceNpcNotify>, IMessage, IEquatable<SilenceNpcNotify>, IDeepCloneable<SilenceNpcNotify>, IBufferMessage
	{
		// Token: 0x0601911B RID: 102683 RVA: 0x003A77F9 File Offset: 0x003A59F9
		[NullableContext(1)]
		public static SilenceNpcNotify Create()
		{
			return new SilenceNpcNotify();
		}

		// Token: 0x170054B6 RID: 21686
		// (get) Token: 0x0601911C RID: 102684 RVA: 0x003A7800 File Offset: 0x003A5A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054B7 RID: 21687
		// (get) Token: 0x0601911D RID: 102685 RVA: 0x003A7803 File Offset: 0x003A5A03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SilenceNpcNotify.Descriptor;
			}
		}

		// Token: 0x0601911E RID: 102686 RVA: 0x003A780A File Offset: 0x003A5A0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SilenceNpcNotify()
		{
		}

		// Token: 0x0601911F RID: 102687 RVA: 0x003A781D File Offset: 0x003A5A1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SilenceNpcNotify(SilenceNpcNotify other) : this()
		{
			this.silenceNpc_ = other.silenceNpc_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019120 RID: 102688 RVA: 0x003A7847 File Offset: 0x003A5A47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SilenceNpcNotify Clone()
		{
			return new SilenceNpcNotify(this);
		}

		// Token: 0x170054B8 RID: 21688
		// (get) Token: 0x06019121 RID: 102689 RVA: 0x003A784F File Offset: 0x003A5A4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, bool> SilenceNpc
		{
			get
			{
				return this.silenceNpc_;
			}
		}

		// Token: 0x06019122 RID: 102690 RVA: 0x003A7857 File Offset: 0x003A5A57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SilenceNpcNotify);
		}

		// Token: 0x06019123 RID: 102691 RVA: 0x003A7865 File Offset: 0x003A5A65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SilenceNpcNotify other)
		{
			return other != null && (other == this || (this.SilenceNpc.Equals(other.SilenceNpc) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019124 RID: 102692 RVA: 0x003A7898 File Offset: 0x003A5A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.SilenceNpc.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019125 RID: 102693 RVA: 0x003A78CC File Offset: 0x003A5ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019126 RID: 102694 RVA: 0x003A78D9 File Offset: 0x003A5AD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019127 RID: 102695 RVA: 0x003A78E2 File Offset: 0x003A5AE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.silenceNpc_.WriteTo(ref output, SilenceNpcNotify._map_silenceNpc_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019128 RID: 102696 RVA: 0x003A790C File Offset: 0x003A5B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.silenceNpc_.CalculateSize(SilenceNpcNotify._map_silenceNpc_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019129 RID: 102697 RVA: 0x003A7945 File Offset: 0x003A5B45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SilenceNpcNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.silenceNpc_.MergeFrom(other.silenceNpc_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601912A RID: 102698 RVA: 0x003A7973 File Offset: 0x003A5B73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601912B RID: 102699 RVA: 0x003A797C File Offset: 0x003A5B7C
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.silenceNpc_.AddEntriesFrom(ref input, SilenceNpcNotify._map_silenceNpc_codec);
				}
			}
		}

		// Token: 0x04009486 RID: 38022
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009487 RID: 38023
		public const int SilenceNpcFieldNumber = 2;

		// Token: 0x04009488 RID: 38024
		private static readonly MapField<int, bool>.Codec _map_silenceNpc_codec = new MapField<int, bool>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForBool(16U, false), 18U);

		// Token: 0x04009489 RID: 38025
		private readonly MapField<int, bool> silenceNpc_ = new MapField<int, bool>();
	}
}
