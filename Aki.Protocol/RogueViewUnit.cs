using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001019 RID: 4121
	public sealed class RogueViewUnit : IMessage<RogueViewUnit>, IMessage, IEquatable<RogueViewUnit>, IDeepCloneable<RogueViewUnit>, IBufferMessage
	{
		// Token: 0x060160DE RID: 90334 RVA: 0x00334F29 File Offset: 0x00333129
		[NullableContext(1)]
		public static RogueViewUnit Create()
		{
			return new RogueViewUnit();
		}

		// Token: 0x170049BB RID: 18875
		// (get) Token: 0x060160DF RID: 90335 RVA: 0x00334F30 File Offset: 0x00333130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueViewUnit> Parser
		{
			get
			{
				return RogueViewUnit._parser;
			}
		}

		// Token: 0x170049BC RID: 18876
		// (get) Token: 0x060160E0 RID: 90336 RVA: 0x00334F37 File Offset: 0x00333137
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049BD RID: 18877
		// (get) Token: 0x060160E1 RID: 90337 RVA: 0x00334F3A File Offset: 0x0033313A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueViewUnit.Descriptor;
			}
		}

		// Token: 0x060160E2 RID: 90338 RVA: 0x00334F41 File Offset: 0x00333141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueViewUnit()
		{
		}

		// Token: 0x060160E3 RID: 90339 RVA: 0x00334F4C File Offset: 0x0033314C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueViewUnit(RogueViewUnit other) : this()
		{
			RogueViewUnit.DataOneofCase dataCase = other.DataCase;
			if (dataCase != RogueViewUnit.DataOneofCase.RoguelikeEventGainNotify)
			{
				if (dataCase == RogueViewUnit.DataOneofCase.ItemObtainNotify)
				{
					this.ItemObtainNotify = other.ItemObtainNotify.Clone();
				}
			}
			else
			{
				this.RoguelikeEventGainNotify = other.RoguelikeEventGainNotify.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060160E4 RID: 90340 RVA: 0x00334FA5 File Offset: 0x003331A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueViewUnit Clone()
		{
			return new RogueViewUnit(this);
		}

		// Token: 0x170049BE RID: 18878
		// (get) Token: 0x060160E5 RID: 90341 RVA: 0x00334FAD File Offset: 0x003331AD
		// (set) Token: 0x060160E6 RID: 90342 RVA: 0x00334FC5 File Offset: 0x003331C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeEventGainNotify RoguelikeEventGainNotify
		{
			get
			{
				if (this.dataCase_ != RogueViewUnit.DataOneofCase.RoguelikeEventGainNotify)
				{
					return null;
				}
				return (RoguelikeEventGainNotify)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RogueViewUnit.DataOneofCase.None : RogueViewUnit.DataOneofCase.RoguelikeEventGainNotify);
			}
		}

		// Token: 0x170049BF RID: 18879
		// (get) Token: 0x060160E7 RID: 90343 RVA: 0x00334FDB File Offset: 0x003331DB
		// (set) Token: 0x060160E8 RID: 90344 RVA: 0x00334FF3 File Offset: 0x003331F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemObtainNotify ItemObtainNotify
		{
			get
			{
				if (this.dataCase_ != RogueViewUnit.DataOneofCase.ItemObtainNotify)
				{
					return null;
				}
				return (ItemObtainNotify)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RogueViewUnit.DataOneofCase.None : RogueViewUnit.DataOneofCase.ItemObtainNotify);
			}
		}

		// Token: 0x170049C0 RID: 18880
		// (get) Token: 0x060160E9 RID: 90345 RVA: 0x00335009 File Offset: 0x00333209
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueViewUnit.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x060160EA RID: 90346 RVA: 0x00335011 File Offset: 0x00333211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = RogueViewUnit.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x060160EB RID: 90347 RVA: 0x00335021 File Offset: 0x00333221
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueViewUnit);
		}

		// Token: 0x060160EC RID: 90348 RVA: 0x00335030 File Offset: 0x00333230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueViewUnit other)
		{
			return other != null && (other == this || (object.Equals(this.RoguelikeEventGainNotify, other.RoguelikeEventGainNotify) && object.Equals(this.ItemObtainNotify, other.ItemObtainNotify) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060160ED RID: 90349 RVA: 0x00335094 File Offset: 0x00333294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.dataCase_ == RogueViewUnit.DataOneofCase.RoguelikeEventGainNotify)
			{
				num ^= this.RoguelikeEventGainNotify.GetHashCode();
			}
			if (this.dataCase_ == RogueViewUnit.DataOneofCase.ItemObtainNotify)
			{
				num ^= this.ItemObtainNotify.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060160EE RID: 90350 RVA: 0x003350F1 File Offset: 0x003332F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060160EF RID: 90351 RVA: 0x003350FE File Offset: 0x003332FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060160F0 RID: 90352 RVA: 0x00335108 File Offset: 0x00333308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.dataCase_ == RogueViewUnit.DataOneofCase.RoguelikeEventGainNotify)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RoguelikeEventGainNotify);
			}
			if (this.dataCase_ == RogueViewUnit.DataOneofCase.ItemObtainNotify)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ItemObtainNotify);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060160F1 RID: 90353 RVA: 0x00335164 File Offset: 0x00333364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.dataCase_ == RogueViewUnit.DataOneofCase.RoguelikeEventGainNotify)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoguelikeEventGainNotify);
			}
			if (this.dataCase_ == RogueViewUnit.DataOneofCase.ItemObtainNotify)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ItemObtainNotify);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060160F2 RID: 90354 RVA: 0x003351BC File Offset: 0x003333BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueViewUnit other)
		{
			if (other == null)
			{
				return;
			}
			RogueViewUnit.DataOneofCase dataCase = other.DataCase;
			if (dataCase != RogueViewUnit.DataOneofCase.RoguelikeEventGainNotify)
			{
				if (dataCase == RogueViewUnit.DataOneofCase.ItemObtainNotify)
				{
					if (this.ItemObtainNotify == null)
					{
						this.ItemObtainNotify = new ItemObtainNotify();
					}
					this.ItemObtainNotify.MergeFrom(other.ItemObtainNotify);
				}
			}
			else
			{
				if (this.RoguelikeEventGainNotify == null)
				{
					this.RoguelikeEventGainNotify = new RoguelikeEventGainNotify();
				}
				this.RoguelikeEventGainNotify.MergeFrom(other.RoguelikeEventGainNotify);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060160F3 RID: 90355 RVA: 0x0033523F File Offset: 0x0033343F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060160F4 RID: 90356 RVA: 0x00335248 File Offset: 0x00333448
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
						ItemObtainNotify itemObtainNotify = new ItemObtainNotify();
						if (this.dataCase_ == RogueViewUnit.DataOneofCase.ItemObtainNotify)
						{
							itemObtainNotify.MergeFrom(this.ItemObtainNotify);
						}
						input.ReadMessage(itemObtainNotify);
						this.ItemObtainNotify = itemObtainNotify;
					}
				}
				else
				{
					RoguelikeEventGainNotify roguelikeEventGainNotify = new RoguelikeEventGainNotify();
					if (this.dataCase_ == RogueViewUnit.DataOneofCase.RoguelikeEventGainNotify)
					{
						roguelikeEventGainNotify.MergeFrom(this.RoguelikeEventGainNotify);
					}
					input.ReadMessage(roguelikeEventGainNotify);
					this.RoguelikeEventGainNotify = roguelikeEventGainNotify;
				}
			}
		}

		// Token: 0x04008497 RID: 33943
		private static readonly MessageParser<RogueViewUnit> _parser = new MessageParser<RogueViewUnit>(() => new RogueViewUnit());

		// Token: 0x04008498 RID: 33944
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008499 RID: 33945
		public const int RoguelikeEventGainNotifyFieldNumber = 1;

		// Token: 0x0400849A RID: 33946
		public const int ItemObtainNotifyFieldNumber = 2;

		// Token: 0x0400849B RID: 33947
		private object data_;

		// Token: 0x0400849C RID: 33948
		private RogueViewUnit.DataOneofCase dataCase_;

		// Token: 0x020019BB RID: 6587
		public enum DataOneofCase
		{
			// Token: 0x0400CECE RID: 52942
			None,
			// Token: 0x0400CECF RID: 52943
			RoguelikeEventGainNotify,
			// Token: 0x0400CED0 RID: 52944
			ItemObtainNotify
		}
	}
}
