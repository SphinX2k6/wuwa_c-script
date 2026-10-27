using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200121C RID: 4636
	[NetMessage(EMessageId.SilenceNpcNotify)]
	public sealed class SilenceNpcNotify : IMessage<SilenceNpcNotify>, IMessage, IEquatable<SilenceNpcNotify>, IDeepCloneable<SilenceNpcNotify>, IBufferMessage
	{
		// Token: 0x06018B41 RID: 101185 RVA: 0x00397951 File Offset: 0x00395B51
		[NullableContext(1)]
		public static SilenceNpcNotify Create()
		{
			return new SilenceNpcNotify();
		}

		// Token: 0x17005339 RID: 21305
		// (get) Token: 0x06018B42 RID: 101186 RVA: 0x00397958 File Offset: 0x00395B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700533A RID: 21306
		// (get) Token: 0x06018B43 RID: 101187 RVA: 0x0039795B File Offset: 0x00395B5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SilenceNpcNotify.Descriptor;
			}
		}

		// Token: 0x06018B44 RID: 101188 RVA: 0x00397962 File Offset: 0x00395B62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SilenceNpcNotify()
		{
		}

		// Token: 0x06018B45 RID: 101189 RVA: 0x00397975 File Offset: 0x00395B75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SilenceNpcNotify(SilenceNpcNotify other) : this()
		{
			this.silenceNpc_ = other.silenceNpc_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018B46 RID: 101190 RVA: 0x0039799F File Offset: 0x00395B9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SilenceNpcNotify Clone()
		{
			return new SilenceNpcNotify(this);
		}

		// Token: 0x1700533B RID: 21307
		// (get) Token: 0x06018B47 RID: 101191 RVA: 0x003979A7 File Offset: 0x00395BA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, bool> SilenceNpc
		{
			get
			{
				return this.silenceNpc_;
			}
		}

		// Token: 0x06018B48 RID: 101192 RVA: 0x003979AF File Offset: 0x00395BAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SilenceNpcNotify);
		}

		// Token: 0x06018B49 RID: 101193 RVA: 0x003979BD File Offset: 0x00395BBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SilenceNpcNotify other)
		{
			return other != null && (other == this || (this.SilenceNpc.Equals(other.SilenceNpc) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018B4A RID: 101194 RVA: 0x003979F0 File Offset: 0x00395BF0
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

		// Token: 0x06018B4B RID: 101195 RVA: 0x00397A24 File Offset: 0x00395C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018B4C RID: 101196 RVA: 0x00397A31 File Offset: 0x00395C31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018B4D RID: 101197 RVA: 0x00397A3A File Offset: 0x00395C3A
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

		// Token: 0x06018B4E RID: 101198 RVA: 0x00397A64 File Offset: 0x00395C64
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

		// Token: 0x06018B4F RID: 101199 RVA: 0x00397A9D File Offset: 0x00395C9D
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

		// Token: 0x06018B50 RID: 101200 RVA: 0x00397ACB File Offset: 0x00395CCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018B51 RID: 101201 RVA: 0x00397AD4 File Offset: 0x00395CD4
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.silenceNpc_.AddEntriesFrom(ref input, SilenceNpcNotify._map_silenceNpc_codec);
				}
			}
		}

		// Token: 0x040091D5 RID: 37333
		private UnknownFieldSet _unknownFields;

		// Token: 0x040091D6 RID: 37334
		public const int SilenceNpcFieldNumber = 11;

		// Token: 0x040091D7 RID: 37335
		private static readonly MapField<int, bool>.Codec _map_silenceNpc_codec = new MapField<int, bool>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForBool(16U, false), 90U);

		// Token: 0x040091D8 RID: 37336
		private readonly MapField<int, bool> silenceNpc_ = new MapField<int, bool>();
	}
}
