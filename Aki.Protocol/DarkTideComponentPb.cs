using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200039E RID: 926
	public sealed class DarkTideComponentPb : IMessage<DarkTideComponentPb>, IMessage, IEquatable<DarkTideComponentPb>, IDeepCloneable<DarkTideComponentPb>, IBufferMessage
	{
		// Token: 0x06005B43 RID: 23363 RVA: 0x000DE029 File Offset: 0x000DC229
		[NullableContext(1)]
		public static DarkTideComponentPb Create()
		{
			return new DarkTideComponentPb();
		}

		// Token: 0x170010E7 RID: 4327
		// (get) Token: 0x06005B44 RID: 23364 RVA: 0x000DE030 File Offset: 0x000DC230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010E8 RID: 4328
		// (get) Token: 0x06005B45 RID: 23365 RVA: 0x000DE033 File Offset: 0x000DC233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkTideComponentPb.Descriptor;
			}
		}

		// Token: 0x06005B46 RID: 23366 RVA: 0x000DE03A File Offset: 0x000DC23A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideComponentPb()
		{
		}

		// Token: 0x06005B47 RID: 23367 RVA: 0x000DE044 File Offset: 0x000DC244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideComponentPb(DarkTideComponentPb other) : this()
		{
			this.darkTideDropEntityComponentPb_ = ((other.darkTideDropEntityComponentPb_ != null) ? other.darkTideDropEntityComponentPb_.Clone() : null);
			this.darkTideItemMarkPb_ = ((other.darkTideItemMarkPb_ != null) ? other.darkTideItemMarkPb_.Clone() : null);
			this.selectVisionIndex_ = other.selectVisionIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005B48 RID: 23368 RVA: 0x000DE0AC File Offset: 0x000DC2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideComponentPb Clone()
		{
			return new DarkTideComponentPb(this);
		}

		// Token: 0x170010E9 RID: 4329
		// (get) Token: 0x06005B49 RID: 23369 RVA: 0x000DE0B4 File Offset: 0x000DC2B4
		// (set) Token: 0x06005B4A RID: 23370 RVA: 0x000DE0BC File Offset: 0x000DC2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideDropEntityComponentPb DarkTideDropEntityComponentPb
		{
			get
			{
				return this.darkTideDropEntityComponentPb_;
			}
			set
			{
				this.darkTideDropEntityComponentPb_ = value;
			}
		}

		// Token: 0x170010EA RID: 4330
		// (get) Token: 0x06005B4B RID: 23371 RVA: 0x000DE0C5 File Offset: 0x000DC2C5
		// (set) Token: 0x06005B4C RID: 23372 RVA: 0x000DE0CD File Offset: 0x000DC2CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideItemMarkPb DarkTideItemMarkPb
		{
			get
			{
				return this.darkTideItemMarkPb_;
			}
			set
			{
				this.darkTideItemMarkPb_ = value;
			}
		}

		// Token: 0x170010EB RID: 4331
		// (get) Token: 0x06005B4D RID: 23373 RVA: 0x000DE0D6 File Offset: 0x000DC2D6
		// (set) Token: 0x06005B4E RID: 23374 RVA: 0x000DE0DE File Offset: 0x000DC2DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SelectVisionIndex
		{
			get
			{
				return this.selectVisionIndex_;
			}
			set
			{
				this.selectVisionIndex_ = value;
			}
		}

		// Token: 0x06005B4F RID: 23375 RVA: 0x000DE0E7 File Offset: 0x000DC2E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkTideComponentPb);
		}

		// Token: 0x06005B50 RID: 23376 RVA: 0x000DE0F8 File Offset: 0x000DC2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkTideComponentPb other)
		{
			return other != null && (other == this || (object.Equals(this.DarkTideDropEntityComponentPb, other.DarkTideDropEntityComponentPb) && object.Equals(this.DarkTideItemMarkPb, other.DarkTideItemMarkPb) && this.SelectVisionIndex == other.SelectVisionIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005B51 RID: 23377 RVA: 0x000DE15C File Offset: 0x000DC35C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.darkTideDropEntityComponentPb_ != null)
			{
				num ^= this.DarkTideDropEntityComponentPb.GetHashCode();
			}
			if (this.darkTideItemMarkPb_ != null)
			{
				num ^= this.DarkTideItemMarkPb.GetHashCode();
			}
			if (this.SelectVisionIndex != 0)
			{
				num ^= this.SelectVisionIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005B52 RID: 23378 RVA: 0x000DE1C7 File Offset: 0x000DC3C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005B53 RID: 23379 RVA: 0x000DE1D4 File Offset: 0x000DC3D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005B54 RID: 23380 RVA: 0x000DE1E0 File Offset: 0x000DC3E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.darkTideDropEntityComponentPb_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.DarkTideDropEntityComponentPb);
			}
			if (this.darkTideItemMarkPb_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.DarkTideItemMarkPb);
			}
			if (this.SelectVisionIndex != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SelectVisionIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005B55 RID: 23381 RVA: 0x000DE258 File Offset: 0x000DC458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.darkTideDropEntityComponentPb_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DarkTideDropEntityComponentPb);
			}
			if (this.darkTideItemMarkPb_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DarkTideItemMarkPb);
			}
			if (this.SelectVisionIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SelectVisionIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005B56 RID: 23382 RVA: 0x000DE2C8 File Offset: 0x000DC4C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DarkTideComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.darkTideDropEntityComponentPb_ != null)
			{
				if (this.darkTideDropEntityComponentPb_ == null)
				{
					this.DarkTideDropEntityComponentPb = new DarkTideDropEntityComponentPb();
				}
				this.DarkTideDropEntityComponentPb.MergeFrom(other.DarkTideDropEntityComponentPb);
			}
			if (other.darkTideItemMarkPb_ != null)
			{
				if (this.darkTideItemMarkPb_ == null)
				{
					this.DarkTideItemMarkPb = new DarkTideItemMarkPb();
				}
				this.DarkTideItemMarkPb.MergeFrom(other.DarkTideItemMarkPb);
			}
			if (other.SelectVisionIndex != 0)
			{
				this.SelectVisionIndex = other.SelectVisionIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005B57 RID: 23383 RVA: 0x000DE35C File Offset: 0x000DC55C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005B58 RID: 23384 RVA: 0x000DE368 File Offset: 0x000DC568
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SelectVisionIndex = input.ReadInt32();
						}
					}
					else
					{
						if (this.darkTideItemMarkPb_ == null)
						{
							this.DarkTideItemMarkPb = new DarkTideItemMarkPb();
						}
						input.ReadMessage(this.DarkTideItemMarkPb);
					}
				}
				else
				{
					if (this.darkTideDropEntityComponentPb_ == null)
					{
						this.DarkTideDropEntityComponentPb = new DarkTideDropEntityComponentPb();
					}
					input.ReadMessage(this.DarkTideDropEntityComponentPb);
				}
			}
		}

		// Token: 0x040035F9 RID: 13817
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035FA RID: 13818
		public const int DarkTideDropEntityComponentPbFieldNumber = 1;

		// Token: 0x040035FB RID: 13819
		private DarkTideDropEntityComponentPb darkTideDropEntityComponentPb_;

		// Token: 0x040035FC RID: 13820
		public const int DarkTideItemMarkPbFieldNumber = 2;

		// Token: 0x040035FD RID: 13821
		private DarkTideItemMarkPb darkTideItemMarkPb_;

		// Token: 0x040035FE RID: 13822
		public const int SelectVisionIndexFieldNumber = 3;

		// Token: 0x040035FF RID: 13823
		private int selectVisionIndex_;
	}
}
