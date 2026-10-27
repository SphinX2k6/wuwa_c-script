using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000773 RID: 1907
	public sealed class HonamiStoryDropItemComponentPb : IMessage<HonamiStoryDropItemComponentPb>, IMessage, IEquatable<HonamiStoryDropItemComponentPb>, IDeepCloneable<HonamiStoryDropItemComponentPb>, IBufferMessage
	{
		// Token: 0x0600AC5F RID: 44127 RVA: 0x0019E5FD File Offset: 0x0019C7FD
		[NullableContext(1)]
		public static HonamiStoryDropItemComponentPb Create()
		{
			return new HonamiStoryDropItemComponentPb();
		}

		// Token: 0x170022BD RID: 8893
		// (get) Token: 0x0600AC60 RID: 44128 RVA: 0x0019E604 File Offset: 0x0019C804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022BE RID: 8894
		// (get) Token: 0x0600AC61 RID: 44129 RVA: 0x0019E607 File Offset: 0x0019C807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryDropItemComponentPb.Descriptor;
			}
		}

		// Token: 0x0600AC62 RID: 44130 RVA: 0x0019E60E File Offset: 0x0019C80E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryDropItemComponentPb()
		{
		}

		// Token: 0x0600AC63 RID: 44131 RVA: 0x0019E616 File Offset: 0x0019C816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryDropItemComponentPb(HonamiStoryDropItemComponentPb other) : this()
		{
			this.honamiStoryItemInfo_ = ((other.honamiStoryItemInfo_ != null) ? other.honamiStoryItemInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AC64 RID: 44132 RVA: 0x0019E64B File Offset: 0x0019C84B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryDropItemComponentPb Clone()
		{
			return new HonamiStoryDropItemComponentPb(this);
		}

		// Token: 0x170022BF RID: 8895
		// (get) Token: 0x0600AC65 RID: 44133 RVA: 0x0019E653 File Offset: 0x0019C853
		// (set) Token: 0x0600AC66 RID: 44134 RVA: 0x0019E65B File Offset: 0x0019C85B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemInfo HonamiStoryItemInfo
		{
			get
			{
				return this.honamiStoryItemInfo_;
			}
			set
			{
				this.honamiStoryItemInfo_ = value;
			}
		}

		// Token: 0x0600AC67 RID: 44135 RVA: 0x0019E664 File Offset: 0x0019C864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryDropItemComponentPb);
		}

		// Token: 0x0600AC68 RID: 44136 RVA: 0x0019E672 File Offset: 0x0019C872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryDropItemComponentPb other)
		{
			return other != null && (other == this || (object.Equals(this.HonamiStoryItemInfo, other.HonamiStoryItemInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AC69 RID: 44137 RVA: 0x0019E6A8 File Offset: 0x0019C8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.honamiStoryItemInfo_ != null)
			{
				num ^= this.HonamiStoryItemInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AC6A RID: 44138 RVA: 0x0019E6E4 File Offset: 0x0019C8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AC6B RID: 44139 RVA: 0x0019E6F1 File Offset: 0x0019C8F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AC6C RID: 44140 RVA: 0x0019E6FA File Offset: 0x0019C8FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.honamiStoryItemInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.HonamiStoryItemInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AC6D RID: 44141 RVA: 0x0019E72C File Offset: 0x0019C92C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.honamiStoryItemInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HonamiStoryItemInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AC6E RID: 44142 RVA: 0x0019E76C File Offset: 0x0019C96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryDropItemComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.honamiStoryItemInfo_ != null)
			{
				if (this.honamiStoryItemInfo_ == null)
				{
					this.HonamiStoryItemInfo = new HonamiStoryItemInfo();
				}
				this.HonamiStoryItemInfo.MergeFrom(other.HonamiStoryItemInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AC6F RID: 44143 RVA: 0x0019E7C0 File Offset: 0x0019C9C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AC70 RID: 44144 RVA: 0x0019E7CC File Offset: 0x0019C9CC
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
					if (this.honamiStoryItemInfo_ == null)
					{
						this.HonamiStoryItemInfo = new HonamiStoryItemInfo();
					}
					input.ReadMessage(this.HonamiStoryItemInfo);
				}
			}
		}

		// Token: 0x04004E13 RID: 19987
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E14 RID: 19988
		public const int HonamiStoryItemInfoFieldNumber = 1;

		// Token: 0x04004E15 RID: 19989
		private HonamiStoryItemInfo honamiStoryItemInfo_;
	}
}
