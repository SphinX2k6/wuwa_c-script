using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200003D RID: 61
	[NetMessage(EMessageId.AbyssReviveNotify)]
	public sealed class AbyssReviveNotify : IMessage<AbyssReviveNotify>, IMessage, IEquatable<AbyssReviveNotify>, IDeepCloneable<AbyssReviveNotify>, IBufferMessage
	{
		// Token: 0x06001352 RID: 4946 RVA: 0x000347DD File Offset: 0x000329DD
		[NullableContext(1)]
		public static AbyssReviveNotify Create()
		{
			return new AbyssReviveNotify();
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06001353 RID: 4947 RVA: 0x000347E4 File Offset: 0x000329E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06001354 RID: 4948 RVA: 0x000347E7 File Offset: 0x000329E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssReviveNotify.Descriptor;
			}
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x000347EE File Offset: 0x000329EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssReviveNotify()
		{
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x000347F6 File Offset: 0x000329F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssReviveNotify(AbyssReviveNotify other) : this()
		{
			this.maxReviveTimes_ = other.maxReviveTimes_;
			this.curReviveTimes_ = other.curReviveTimes_;
			this.curRevieTimes_ = other.curRevieTimes_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x00034833 File Offset: 0x00032A33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssReviveNotify Clone()
		{
			return new AbyssReviveNotify(this);
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06001358 RID: 4952 RVA: 0x0003483B File Offset: 0x00032A3B
		// (set) Token: 0x06001359 RID: 4953 RVA: 0x00034843 File Offset: 0x00032A43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxReviveTimes
		{
			get
			{
				return this.maxReviveTimes_;
			}
			set
			{
				this.maxReviveTimes_ = value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600135A RID: 4954 RVA: 0x0003484C File Offset: 0x00032A4C
		// (set) Token: 0x0600135B RID: 4955 RVA: 0x00034854 File Offset: 0x00032A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurReviveTimes
		{
			get
			{
				return this.curReviveTimes_;
			}
			set
			{
				this.curReviveTimes_ = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600135C RID: 4956 RVA: 0x0003485D File Offset: 0x00032A5D
		// (set) Token: 0x0600135D RID: 4957 RVA: 0x00034865 File Offset: 0x00032A65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurRevieTimes
		{
			get
			{
				return this.curRevieTimes_;
			}
			set
			{
				this.curRevieTimes_ = value;
			}
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x0003486E File Offset: 0x00032A6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssReviveNotify);
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x0003487C File Offset: 0x00032A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssReviveNotify other)
		{
			return other != null && (other == this || (this.MaxReviveTimes == other.MaxReviveTimes && this.CurReviveTimes == other.CurReviveTimes && this.CurRevieTimes == other.CurRevieTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x000348D8 File Offset: 0x00032AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MaxReviveTimes != 0)
			{
				num ^= this.MaxReviveTimes.GetHashCode();
			}
			if (this.CurReviveTimes != 0)
			{
				num ^= this.CurReviveTimes.GetHashCode();
			}
			if (this.CurRevieTimes != 0)
			{
				num ^= this.CurRevieTimes.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x00034949 File Offset: 0x00032B49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x00034956 File Offset: 0x00032B56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x00034960 File Offset: 0x00032B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurReviveTimes != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.CurReviveTimes);
			}
			if (this.MaxReviveTimes != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.MaxReviveTimes);
			}
			if (this.CurRevieTimes != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.CurRevieTimes);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x000349D8 File Offset: 0x00032BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MaxReviveTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxReviveTimes);
			}
			if (this.CurReviveTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurReviveTimes);
			}
			if (this.CurRevieTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurRevieTimes);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x00034A48 File Offset: 0x00032C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssReviveNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MaxReviveTimes != 0)
			{
				this.MaxReviveTimes = other.MaxReviveTimes;
			}
			if (other.CurReviveTimes != 0)
			{
				this.CurReviveTimes = other.CurReviveTimes;
			}
			if (other.CurRevieTimes != 0)
			{
				this.CurRevieTimes = other.CurRevieTimes;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x00034AAC File Offset: 0x00032CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x00034AB8 File Offset: 0x00032CB8
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
				if (num != 48U)
				{
					if (num != 88U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CurRevieTimes = input.ReadInt32();
						}
					}
					else
					{
						this.MaxReviveTimes = input.ReadInt32();
					}
				}
				else
				{
					this.CurReviveTimes = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002007 RID: 8199
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002008 RID: 8200
		public const int MaxReviveTimesFieldNumber = 11;

		// Token: 0x04002009 RID: 8201
		private int maxReviveTimes_;

		// Token: 0x0400200A RID: 8202
		public const int CurReviveTimesFieldNumber = 6;

		// Token: 0x0400200B RID: 8203
		private int curReviveTimes_;

		// Token: 0x0400200C RID: 8204
		public const int CurRevieTimesFieldNumber = 15;

		// Token: 0x0400200D RID: 8205
		private int curRevieTimes_;
	}
}
