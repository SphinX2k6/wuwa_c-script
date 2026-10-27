using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000292 RID: 658
	public sealed class CiacconaInspirationPbData : IMessage<CiacconaInspirationPbData>, IMessage, IEquatable<CiacconaInspirationPbData>, IDeepCloneable<CiacconaInspirationPbData>, IBufferMessage
	{
		// Token: 0x060044A0 RID: 17568 RVA: 0x000A85DA File Offset: 0x000A67DA
		[NullableContext(1)]
		public static CiacconaInspirationPbData Create()
		{
			return new CiacconaInspirationPbData();
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x060044A1 RID: 17569 RVA: 0x000A85E1 File Offset: 0x000A67E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x060044A2 RID: 17570 RVA: 0x000A85E4 File Offset: 0x000A67E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CiacconaInspirationPbData.Descriptor;
			}
		}

		// Token: 0x060044A3 RID: 17571 RVA: 0x000A85EB File Offset: 0x000A67EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaInspirationPbData()
		{
		}

		// Token: 0x060044A4 RID: 17572 RVA: 0x000A85F3 File Offset: 0x000A67F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaInspirationPbData(CiacconaInspirationPbData other) : this()
		{
			this.inspiration_ = other.inspiration_;
			this.refreshTime_ = other.refreshTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060044A5 RID: 17573 RVA: 0x000A8624 File Offset: 0x000A6824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaInspirationPbData Clone()
		{
			return new CiacconaInspirationPbData(this);
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x060044A6 RID: 17574 RVA: 0x000A862C File Offset: 0x000A682C
		// (set) Token: 0x060044A7 RID: 17575 RVA: 0x000A8634 File Offset: 0x000A6834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Inspiration
		{
			get
			{
				return this.inspiration_;
			}
			set
			{
				this.inspiration_ = value;
			}
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x060044A8 RID: 17576 RVA: 0x000A863D File Offset: 0x000A683D
		// (set) Token: 0x060044A9 RID: 17577 RVA: 0x000A8645 File Offset: 0x000A6845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RefreshTime
		{
			get
			{
				return this.refreshTime_;
			}
			set
			{
				this.refreshTime_ = value;
			}
		}

		// Token: 0x060044AA RID: 17578 RVA: 0x000A864E File Offset: 0x000A684E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CiacconaInspirationPbData);
		}

		// Token: 0x060044AB RID: 17579 RVA: 0x000A865C File Offset: 0x000A685C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CiacconaInspirationPbData other)
		{
			return other != null && (other == this || (this.Inspiration == other.Inspiration && this.RefreshTime == other.RefreshTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060044AC RID: 17580 RVA: 0x000A869C File Offset: 0x000A689C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Inspiration != 0)
			{
				num ^= this.Inspiration.GetHashCode();
			}
			if (this.RefreshTime != 0L)
			{
				num ^= this.RefreshTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060044AD RID: 17581 RVA: 0x000A86F4 File Offset: 0x000A68F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060044AE RID: 17582 RVA: 0x000A8701 File Offset: 0x000A6901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060044AF RID: 17583 RVA: 0x000A870C File Offset: 0x000A690C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Inspiration != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Inspiration);
			}
			if (this.RefreshTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.RefreshTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060044B0 RID: 17584 RVA: 0x000A8764 File Offset: 0x000A6964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Inspiration != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Inspiration);
			}
			if (this.RefreshTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RefreshTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060044B1 RID: 17585 RVA: 0x000A87BC File Offset: 0x000A69BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CiacconaInspirationPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Inspiration != 0)
			{
				this.Inspiration = other.Inspiration;
			}
			if (other.RefreshTime != 0L)
			{
				this.RefreshTime = other.RefreshTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060044B2 RID: 17586 RVA: 0x000A880C File Offset: 0x000A6A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060044B3 RID: 17587 RVA: 0x000A8818 File Offset: 0x000A6A18
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RefreshTime = input.ReadInt64();
					}
				}
				else
				{
					this.Inspiration = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002EB3 RID: 11955
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EB4 RID: 11956
		public const int InspirationFieldNumber = 1;

		// Token: 0x04002EB5 RID: 11957
		private int inspiration_;

		// Token: 0x04002EB6 RID: 11958
		public const int RefreshTimeFieldNumber = 2;

		// Token: 0x04002EB7 RID: 11959
		private long refreshTime_;
	}
}
