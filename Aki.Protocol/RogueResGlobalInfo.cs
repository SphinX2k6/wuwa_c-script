using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FD1 RID: 4049
	public sealed class RogueResGlobalInfo : IMessage<RogueResGlobalInfo>, IMessage, IEquatable<RogueResGlobalInfo>, IDeepCloneable<RogueResGlobalInfo>, IBufferMessage
	{
		// Token: 0x06015AB8 RID: 88760 RVA: 0x0032605A File Offset: 0x0032425A
		[NullableContext(1)]
		public static RogueResGlobalInfo Create()
		{
			return new RogueResGlobalInfo();
		}

		// Token: 0x17004850 RID: 18512
		// (get) Token: 0x06015AB9 RID: 88761 RVA: 0x00326061 File Offset: 0x00324261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004851 RID: 18513
		// (get) Token: 0x06015ABA RID: 88762 RVA: 0x00326064 File Offset: 0x00324264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResGlobalInfo.Descriptor;
			}
		}

		// Token: 0x06015ABB RID: 88763 RVA: 0x0032606B File Offset: 0x0032426B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGlobalInfo()
		{
		}

		// Token: 0x06015ABC RID: 88764 RVA: 0x00326080 File Offset: 0x00324280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGlobalInfo(RogueResGlobalInfo other) : this()
		{
			this.rogueResTaskUpdateNotify_ = ((other.rogueResTaskUpdateNotify_ != null) ? other.rogueResTaskUpdateNotify_.Clone() : null);
			this.dict_ = other.dict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015ABD RID: 88765 RVA: 0x003260D1 File Offset: 0x003242D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGlobalInfo Clone()
		{
			return new RogueResGlobalInfo(this);
		}

		// Token: 0x17004852 RID: 18514
		// (get) Token: 0x06015ABE RID: 88766 RVA: 0x003260D9 File Offset: 0x003242D9
		// (set) Token: 0x06015ABF RID: 88767 RVA: 0x003260E1 File Offset: 0x003242E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTaskUpdateNotify RogueResTaskUpdateNotify
		{
			get
			{
				return this.rogueResTaskUpdateNotify_;
			}
			set
			{
				this.rogueResTaskUpdateNotify_ = value;
			}
		}

		// Token: 0x17004853 RID: 18515
		// (get) Token: 0x06015AC0 RID: 88768 RVA: 0x003260EA File Offset: 0x003242EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, SignState> Dict
		{
			get
			{
				return this.dict_;
			}
		}

		// Token: 0x06015AC1 RID: 88769 RVA: 0x003260F2 File Offset: 0x003242F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResGlobalInfo);
		}

		// Token: 0x06015AC2 RID: 88770 RVA: 0x00326100 File Offset: 0x00324300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResGlobalInfo other)
		{
			return other != null && (other == this || (object.Equals(this.RogueResTaskUpdateNotify, other.RogueResTaskUpdateNotify) && this.Dict.Equals(other.Dict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015AC3 RID: 88771 RVA: 0x00326154 File Offset: 0x00324354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueResTaskUpdateNotify_ != null)
			{
				num ^= this.RogueResTaskUpdateNotify.GetHashCode();
			}
			num ^= this.Dict.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015AC4 RID: 88772 RVA: 0x0032619E File Offset: 0x0032439E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015AC5 RID: 88773 RVA: 0x003261AB File Offset: 0x003243AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015AC6 RID: 88774 RVA: 0x003261B4 File Offset: 0x003243B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueResTaskUpdateNotify_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RogueResTaskUpdateNotify);
			}
			this.dict_.WriteTo(ref output, RogueResGlobalInfo._map_dict_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015AC7 RID: 88775 RVA: 0x00326204 File Offset: 0x00324404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueResTaskUpdateNotify_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueResTaskUpdateNotify);
			}
			num += this.dict_.CalculateSize(RogueResGlobalInfo._map_dict_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015AC8 RID: 88776 RVA: 0x00326258 File Offset: 0x00324458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResGlobalInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueResTaskUpdateNotify_ != null)
			{
				if (this.rogueResTaskUpdateNotify_ == null)
				{
					this.RogueResTaskUpdateNotify = new RogueResTaskUpdateNotify();
				}
				this.RogueResTaskUpdateNotify.MergeFrom(other.RogueResTaskUpdateNotify);
			}
			this.dict_.MergeFrom(other.dict_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015AC9 RID: 88777 RVA: 0x003262BD File Offset: 0x003244BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015ACA RID: 88778 RVA: 0x003262C8 File Offset: 0x003244C8
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.dict_.AddEntriesFrom(ref input, RogueResGlobalInfo._map_dict_codec);
					}
				}
				else
				{
					if (this.rogueResTaskUpdateNotify_ == null)
					{
						this.RogueResTaskUpdateNotify = new RogueResTaskUpdateNotify();
					}
					input.ReadMessage(this.RogueResTaskUpdateNotify);
				}
			}
		}

		// Token: 0x0400828B RID: 33419
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400828C RID: 33420
		public const int RogueResTaskUpdateNotifyFieldNumber = 1;

		// Token: 0x0400828D RID: 33421
		private RogueResTaskUpdateNotify rogueResTaskUpdateNotify_;

		// Token: 0x0400828E RID: 33422
		public const int DictFieldNumber = 2;

		// Token: 0x0400828F RID: 33423
		private static readonly MapField<int, SignState>.Codec _map_dict_codec = new MapField<int, SignState>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForEnum<SignState>(16U, (SignState x) => (int)x, (int x) => (SignState)x, SignState.Lock), 18U);

		// Token: 0x04008290 RID: 33424
		private readonly MapField<int, SignState> dict_ = new MapField<int, SignState>();
	}
}
