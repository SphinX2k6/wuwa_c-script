using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FE1 RID: 4065
	public sealed class RogueResGlobalInfo : IMessage<RogueResGlobalInfo>, IMessage, IEquatable<RogueResGlobalInfo>, IDeepCloneable<RogueResGlobalInfo>, IBufferMessage
	{
		// Token: 0x06015B9D RID: 88989 RVA: 0x0032770E File Offset: 0x0032590E
		[NullableContext(1)]
		public static RogueResGlobalInfo Create()
		{
			return new RogueResGlobalInfo();
		}

		// Token: 0x1700487A RID: 18554
		// (get) Token: 0x06015B9E RID: 88990 RVA: 0x00327715 File Offset: 0x00325915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700487B RID: 18555
		// (get) Token: 0x06015B9F RID: 88991 RVA: 0x00327718 File Offset: 0x00325918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResGlobalInfo.Descriptor;
			}
		}

		// Token: 0x06015BA0 RID: 88992 RVA: 0x0032771F File Offset: 0x0032591F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGlobalInfo()
		{
		}

		// Token: 0x06015BA1 RID: 88993 RVA: 0x00327734 File Offset: 0x00325934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGlobalInfo(RogueResGlobalInfo other) : this()
		{
			this.rogueResTaskUpdateNotify_ = ((other.rogueResTaskUpdateNotify_ != null) ? other.rogueResTaskUpdateNotify_.Clone() : null);
			this.dict_ = other.dict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015BA2 RID: 88994 RVA: 0x00327785 File Offset: 0x00325985
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGlobalInfo Clone()
		{
			return new RogueResGlobalInfo(this);
		}

		// Token: 0x1700487C RID: 18556
		// (get) Token: 0x06015BA3 RID: 88995 RVA: 0x0032778D File Offset: 0x0032598D
		// (set) Token: 0x06015BA4 RID: 88996 RVA: 0x00327795 File Offset: 0x00325995
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

		// Token: 0x1700487D RID: 18557
		// (get) Token: 0x06015BA5 RID: 88997 RVA: 0x0032779E File Offset: 0x0032599E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, SignState> Dict
		{
			get
			{
				return this.dict_;
			}
		}

		// Token: 0x06015BA6 RID: 88998 RVA: 0x003277A6 File Offset: 0x003259A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResGlobalInfo);
		}

		// Token: 0x06015BA7 RID: 88999 RVA: 0x003277B4 File Offset: 0x003259B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResGlobalInfo other)
		{
			return other != null && (other == this || (object.Equals(this.RogueResTaskUpdateNotify, other.RogueResTaskUpdateNotify) && this.Dict.Equals(other.Dict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015BA8 RID: 89000 RVA: 0x00327808 File Offset: 0x00325A08
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

		// Token: 0x06015BA9 RID: 89001 RVA: 0x00327852 File Offset: 0x00325A52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015BAA RID: 89002 RVA: 0x0032785F File Offset: 0x00325A5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015BAB RID: 89003 RVA: 0x00327868 File Offset: 0x00325A68
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

		// Token: 0x06015BAC RID: 89004 RVA: 0x003278B8 File Offset: 0x00325AB8
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

		// Token: 0x06015BAD RID: 89005 RVA: 0x0032790C File Offset: 0x00325B0C
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

		// Token: 0x06015BAE RID: 89006 RVA: 0x00327971 File Offset: 0x00325B71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015BAF RID: 89007 RVA: 0x0032797C File Offset: 0x00325B7C
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

		// Token: 0x04008261 RID: 33377
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008262 RID: 33378
		public const int RogueResTaskUpdateNotifyFieldNumber = 1;

		// Token: 0x04008263 RID: 33379
		private RogueResTaskUpdateNotify rogueResTaskUpdateNotify_;

		// Token: 0x04008264 RID: 33380
		public const int DictFieldNumber = 2;

		// Token: 0x04008265 RID: 33381
		private static readonly MapField<int, SignState>.Codec _map_dict_codec = new MapField<int, SignState>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForEnum<SignState>(16U, (SignState x) => (int)x, (int x) => (SignState)x, SignState.Lock), 18U);

		// Token: 0x04008266 RID: 33382
		private readonly MapField<int, SignState> dict_ = new MapField<int, SignState>();
	}
}
