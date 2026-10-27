using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001349 RID: 4937
	[NetMessage(EMessageId.TemporaryTeleportAllInfoNotify)]
	public sealed class TemporaryTeleportAllInfoNotify : IMessage<TemporaryTeleportAllInfoNotify>, IMessage, IEquatable<TemporaryTeleportAllInfoNotify>, IDeepCloneable<TemporaryTeleportAllInfoNotify>, IBufferMessage
	{
		// Token: 0x0601A3AE RID: 107438 RVA: 0x003CF7C3 File Offset: 0x003CD9C3
		[NullableContext(1)]
		public static TemporaryTeleportAllInfoNotify Create()
		{
			return new TemporaryTeleportAllInfoNotify();
		}

		// Token: 0x1700587D RID: 22653
		// (get) Token: 0x0601A3AF RID: 107439 RVA: 0x003CF7CA File Offset: 0x003CD9CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700587E RID: 22654
		// (get) Token: 0x0601A3B0 RID: 107440 RVA: 0x003CF7CD File Offset: 0x003CD9CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TemporaryTeleportAllInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601A3B1 RID: 107441 RVA: 0x003CF7D4 File Offset: 0x003CD9D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemporaryTeleportAllInfoNotify()
		{
		}

		// Token: 0x0601A3B2 RID: 107442 RVA: 0x003CF7E7 File Offset: 0x003CD9E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemporaryTeleportAllInfoNotify(TemporaryTeleportAllInfoNotify other) : this()
		{
			this.allTemporaryTeleportInfo_ = other.allTemporaryTeleportInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A3B3 RID: 107443 RVA: 0x003CF811 File Offset: 0x003CDA11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemporaryTeleportAllInfoNotify Clone()
		{
			return new TemporaryTeleportAllInfoNotify(this);
		}

		// Token: 0x1700587F RID: 22655
		// (get) Token: 0x0601A3B4 RID: 107444 RVA: 0x003CF819 File Offset: 0x003CDA19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TemporaryTeleportInfo> AllTemporaryTeleportInfo
		{
			get
			{
				return this.allTemporaryTeleportInfo_;
			}
		}

		// Token: 0x0601A3B5 RID: 107445 RVA: 0x003CF821 File Offset: 0x003CDA21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TemporaryTeleportAllInfoNotify);
		}

		// Token: 0x0601A3B6 RID: 107446 RVA: 0x003CF82F File Offset: 0x003CDA2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TemporaryTeleportAllInfoNotify other)
		{
			return other != null && (other == this || (this.allTemporaryTeleportInfo_.Equals(other.allTemporaryTeleportInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A3B7 RID: 107447 RVA: 0x003CF864 File Offset: 0x003CDA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.allTemporaryTeleportInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A3B8 RID: 107448 RVA: 0x003CF898 File Offset: 0x003CDA98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A3B9 RID: 107449 RVA: 0x003CF8A5 File Offset: 0x003CDAA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A3BA RID: 107450 RVA: 0x003CF8AE File Offset: 0x003CDAAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.allTemporaryTeleportInfo_.WriteTo(ref output, TemporaryTeleportAllInfoNotify._repeated_allTemporaryTeleportInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A3BB RID: 107451 RVA: 0x003CF8D8 File Offset: 0x003CDAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.allTemporaryTeleportInfo_.CalculateSize(TemporaryTeleportAllInfoNotify._repeated_allTemporaryTeleportInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A3BC RID: 107452 RVA: 0x003CF911 File Offset: 0x003CDB11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TemporaryTeleportAllInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.allTemporaryTeleportInfo_.Add(other.allTemporaryTeleportInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A3BD RID: 107453 RVA: 0x003CF93F File Offset: 0x003CDB3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A3BE RID: 107454 RVA: 0x003CF948 File Offset: 0x003CDB48
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
					this.allTemporaryTeleportInfo_.AddEntriesFrom(ref input, TemporaryTeleportAllInfoNotify._repeated_allTemporaryTeleportInfo_codec);
				}
			}
		}

		// Token: 0x04009906 RID: 39174
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009907 RID: 39175
		public const int AllTemporaryTeleportInfoFieldNumber = 1;

		// Token: 0x04009908 RID: 39176
		private static readonly FieldCodec<TemporaryTeleportInfo> _repeated_allTemporaryTeleportInfo_codec = FieldCodec.ForMessage<TemporaryTeleportInfo>(10U, TemporaryTeleportInfo.Parser);

		// Token: 0x04009909 RID: 39177
		private readonly RepeatedField<TemporaryTeleportInfo> allTemporaryTeleportInfo_ = new RepeatedField<TemporaryTeleportInfo>();
	}
}
