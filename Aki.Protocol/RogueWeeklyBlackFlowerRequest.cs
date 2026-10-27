using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001030 RID: 4144
	[NetMessage(EMessageId.RogueWeeklyBlackFlowerRequest)]
	public sealed class RogueWeeklyBlackFlowerRequest : IMessage<RogueWeeklyBlackFlowerRequest>, IMessage, IEquatable<RogueWeeklyBlackFlowerRequest>, IDeepCloneable<RogueWeeklyBlackFlowerRequest>, IBufferMessage
	{
		// Token: 0x06016253 RID: 90707 RVA: 0x003378EC File Offset: 0x00335AEC
		[NullableContext(1)]
		public static RogueWeeklyBlackFlowerRequest Create()
		{
			return new RogueWeeklyBlackFlowerRequest();
		}

		// Token: 0x17004A03 RID: 18947
		// (get) Token: 0x06016254 RID: 90708 RVA: 0x003378F3 File Offset: 0x00335AF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A04 RID: 18948
		// (get) Token: 0x06016255 RID: 90709 RVA: 0x003378F6 File Offset: 0x00335AF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyBlackFlowerRequest.Descriptor;
			}
		}

		// Token: 0x06016256 RID: 90710 RVA: 0x003378FD File Offset: 0x00335AFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyBlackFlowerRequest()
		{
		}

		// Token: 0x06016257 RID: 90711 RVA: 0x00337908 File Offset: 0x00335B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyBlackFlowerRequest(RogueWeeklyBlackFlowerRequest other) : this()
		{
			this.entityConfigId_ = other.entityConfigId_;
			this.ret_ = other.ret_;
			this.isDouble_ = other.isDouble_;
			this.silentAreaId_ = other.silentAreaId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016258 RID: 90712 RVA: 0x0033795C File Offset: 0x00335B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyBlackFlowerRequest Clone()
		{
			return new RogueWeeklyBlackFlowerRequest(this);
		}

		// Token: 0x17004A05 RID: 18949
		// (get) Token: 0x06016259 RID: 90713 RVA: 0x00337964 File Offset: 0x00335B64
		// (set) Token: 0x0601625A RID: 90714 RVA: 0x0033796C File Offset: 0x00335B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityConfigId
		{
			get
			{
				return this.entityConfigId_;
			}
			set
			{
				this.entityConfigId_ = value;
			}
		}

		// Token: 0x17004A06 RID: 18950
		// (get) Token: 0x0601625B RID: 90715 RVA: 0x00337975 File Offset: 0x00335B75
		// (set) Token: 0x0601625C RID: 90716 RVA: 0x0033797D File Offset: 0x00335B7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Ret
		{
			get
			{
				return this.ret_;
			}
			set
			{
				this.ret_ = value;
			}
		}

		// Token: 0x17004A07 RID: 18951
		// (get) Token: 0x0601625D RID: 90717 RVA: 0x00337986 File Offset: 0x00335B86
		// (set) Token: 0x0601625E RID: 90718 RVA: 0x0033798E File Offset: 0x00335B8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsDouble
		{
			get
			{
				return this.isDouble_;
			}
			set
			{
				this.isDouble_ = value;
			}
		}

		// Token: 0x17004A08 RID: 18952
		// (get) Token: 0x0601625F RID: 90719 RVA: 0x00337997 File Offset: 0x00335B97
		// (set) Token: 0x06016260 RID: 90720 RVA: 0x0033799F File Offset: 0x00335B9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SilentAreaId
		{
			get
			{
				return this.silentAreaId_;
			}
			set
			{
				this.silentAreaId_ = value;
			}
		}

		// Token: 0x06016261 RID: 90721 RVA: 0x003379A8 File Offset: 0x00335BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyBlackFlowerRequest);
		}

		// Token: 0x06016262 RID: 90722 RVA: 0x003379B8 File Offset: 0x00335BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyBlackFlowerRequest other)
		{
			return other != null && (other == this || (this.EntityConfigId == other.EntityConfigId && this.Ret == other.Ret && this.IsDouble == other.IsDouble && this.SilentAreaId == other.SilentAreaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016263 RID: 90723 RVA: 0x00337A24 File Offset: 0x00335C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityConfigId != 0)
			{
				num ^= this.EntityConfigId.GetHashCode();
			}
			if (this.Ret)
			{
				num ^= this.Ret.GetHashCode();
			}
			if (this.IsDouble)
			{
				num ^= this.IsDouble.GetHashCode();
			}
			if (this.SilentAreaId != 0)
			{
				num ^= this.SilentAreaId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016264 RID: 90724 RVA: 0x00337AAE File Offset: 0x00335CAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016265 RID: 90725 RVA: 0x00337ABB File Offset: 0x00335CBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016266 RID: 90726 RVA: 0x00337AC4 File Offset: 0x00335CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsDouble)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsDouble);
			}
			if (this.Ret)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.Ret);
			}
			if (this.EntityConfigId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.EntityConfigId);
			}
			if (this.SilentAreaId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.SilentAreaId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016267 RID: 90727 RVA: 0x00337B58 File Offset: 0x00335D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityConfigId);
			}
			if (this.Ret)
			{
				num += 2;
			}
			if (this.IsDouble)
			{
				num += 2;
			}
			if (this.SilentAreaId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SilentAreaId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016268 RID: 90728 RVA: 0x00337BC8 File Offset: 0x00335DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyBlackFlowerRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityConfigId != 0)
			{
				this.EntityConfigId = other.EntityConfigId;
			}
			if (other.Ret)
			{
				this.Ret = other.Ret;
			}
			if (other.IsDouble)
			{
				this.IsDouble = other.IsDouble;
			}
			if (other.SilentAreaId != 0)
			{
				this.SilentAreaId = other.SilentAreaId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016269 RID: 90729 RVA: 0x00337C40 File Offset: 0x00335E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601626A RID: 90730 RVA: 0x00337C4C File Offset: 0x00335E4C
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
				if (num <= 80U)
				{
					if (num == 56U)
					{
						this.IsDouble = input.ReadBool();
						continue;
					}
					if (num == 80U)
					{
						this.Ret = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.EntityConfigId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.SilentAreaId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008492 RID: 33938
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008493 RID: 33939
		public const int EntityConfigIdFieldNumber = 13;

		// Token: 0x04008494 RID: 33940
		private int entityConfigId_;

		// Token: 0x04008495 RID: 33941
		public const int RetFieldNumber = 10;

		// Token: 0x04008496 RID: 33942
		private bool ret_;

		// Token: 0x04008497 RID: 33943
		public const int IsDoubleFieldNumber = 7;

		// Token: 0x04008498 RID: 33944
		private bool isDouble_;

		// Token: 0x04008499 RID: 33945
		public const int SilentAreaIdFieldNumber = 15;

		// Token: 0x0400849A RID: 33946
		private int silentAreaId_;
	}
}
