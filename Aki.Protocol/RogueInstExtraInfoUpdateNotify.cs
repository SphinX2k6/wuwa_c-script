using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F8B RID: 3979
	[NetMessage(EMessageId.RogueInstExtraInfoUpdateNotify)]
	public sealed class RogueInstExtraInfoUpdateNotify : IMessage<RogueInstExtraInfoUpdateNotify>, IMessage, IEquatable<RogueInstExtraInfoUpdateNotify>, IDeepCloneable<RogueInstExtraInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06015473 RID: 87155 RVA: 0x003163B7 File Offset: 0x003145B7
		[NullableContext(1)]
		public static RogueInstExtraInfoUpdateNotify Create()
		{
			return new RogueInstExtraInfoUpdateNotify();
		}

		// Token: 0x170046DE RID: 18142
		// (get) Token: 0x06015474 RID: 87156 RVA: 0x003163BE File Offset: 0x003145BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170046DF RID: 18143
		// (get) Token: 0x06015475 RID: 87157 RVA: 0x003163C1 File Offset: 0x003145C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueInstExtraInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06015476 RID: 87158 RVA: 0x003163C8 File Offset: 0x003145C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInstExtraInfoUpdateNotify()
		{
		}

		// Token: 0x06015477 RID: 87159 RVA: 0x003163D0 File Offset: 0x003145D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInstExtraInfoUpdateNotify(RogueInstExtraInfoUpdateNotify other) : this()
		{
			this.rogueInstExtraInfo_ = ((other.rogueInstExtraInfo_ != null) ? other.rogueInstExtraInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015478 RID: 87160 RVA: 0x00316405 File Offset: 0x00314605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInstExtraInfoUpdateNotify Clone()
		{
			return new RogueInstExtraInfoUpdateNotify(this);
		}

		// Token: 0x170046E0 RID: 18144
		// (get) Token: 0x06015479 RID: 87161 RVA: 0x0031640D File Offset: 0x0031460D
		// (set) Token: 0x0601547A RID: 87162 RVA: 0x00316415 File Offset: 0x00314615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInstExtraInfo RogueInstExtraInfo
		{
			get
			{
				return this.rogueInstExtraInfo_;
			}
			set
			{
				this.rogueInstExtraInfo_ = value;
			}
		}

		// Token: 0x0601547B RID: 87163 RVA: 0x0031641E File Offset: 0x0031461E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueInstExtraInfoUpdateNotify);
		}

		// Token: 0x0601547C RID: 87164 RVA: 0x0031642C File Offset: 0x0031462C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueInstExtraInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.RogueInstExtraInfo, other.RogueInstExtraInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601547D RID: 87165 RVA: 0x00316460 File Offset: 0x00314660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueInstExtraInfo_ != null)
			{
				num ^= this.RogueInstExtraInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601547E RID: 87166 RVA: 0x0031649C File Offset: 0x0031469C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601547F RID: 87167 RVA: 0x003164A9 File Offset: 0x003146A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015480 RID: 87168 RVA: 0x003164B2 File Offset: 0x003146B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueInstExtraInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.RogueInstExtraInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015481 RID: 87169 RVA: 0x003164E4 File Offset: 0x003146E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueInstExtraInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueInstExtraInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015482 RID: 87170 RVA: 0x00316524 File Offset: 0x00314724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueInstExtraInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueInstExtraInfo_ != null)
			{
				if (this.rogueInstExtraInfo_ == null)
				{
					this.RogueInstExtraInfo = new RogueInstExtraInfo();
				}
				this.RogueInstExtraInfo.MergeFrom(other.RogueInstExtraInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015483 RID: 87171 RVA: 0x00316578 File Offset: 0x00314778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015484 RID: 87172 RVA: 0x00316584 File Offset: 0x00314784
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.rogueInstExtraInfo_ == null)
					{
						this.RogueInstExtraInfo = new RogueInstExtraInfo();
					}
					input.ReadMessage(this.RogueInstExtraInfo);
				}
			}
		}

		// Token: 0x04008003 RID: 32771
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008004 RID: 32772
		public const int RogueInstExtraInfoFieldNumber = 4;

		// Token: 0x04008005 RID: 32773
		private RogueInstExtraInfo rogueInstExtraInfo_;
	}
}
