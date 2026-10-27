using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000771 RID: 1905
	[NetMessage(EMessageId.HonamiStoryDiscardItemRequest)]
	public sealed class HonamiStoryDiscardItemRequest : IMessage<HonamiStoryDiscardItemRequest>, IMessage, IEquatable<HonamiStoryDiscardItemRequest>, IDeepCloneable<HonamiStoryDiscardItemRequest>, IBufferMessage
	{
		// Token: 0x0600AC3B RID: 44091 RVA: 0x0019E1F8 File Offset: 0x0019C3F8
		[NullableContext(1)]
		public static HonamiStoryDiscardItemRequest Create()
		{
			return new HonamiStoryDiscardItemRequest();
		}

		// Token: 0x170022B7 RID: 8887
		// (get) Token: 0x0600AC3C RID: 44092 RVA: 0x0019E1FF File Offset: 0x0019C3FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022B8 RID: 8888
		// (get) Token: 0x0600AC3D RID: 44093 RVA: 0x0019E202 File Offset: 0x0019C402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryDiscardItemRequest.Descriptor;
			}
		}

		// Token: 0x0600AC3E RID: 44094 RVA: 0x0019E209 File Offset: 0x0019C409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryDiscardItemRequest()
		{
		}

		// Token: 0x0600AC3F RID: 44095 RVA: 0x0019E211 File Offset: 0x0019C411
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryDiscardItemRequest(HonamiStoryDiscardItemRequest other) : this()
		{
			this.honamiStoryBagUpdateContext_ = ((other.honamiStoryBagUpdateContext_ != null) ? other.honamiStoryBagUpdateContext_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AC40 RID: 44096 RVA: 0x0019E246 File Offset: 0x0019C446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryDiscardItemRequest Clone()
		{
			return new HonamiStoryDiscardItemRequest(this);
		}

		// Token: 0x170022B9 RID: 8889
		// (get) Token: 0x0600AC41 RID: 44097 RVA: 0x0019E24E File Offset: 0x0019C44E
		// (set) Token: 0x0600AC42 RID: 44098 RVA: 0x0019E256 File Offset: 0x0019C456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagUpdateContext HonamiStoryBagUpdateContext
		{
			get
			{
				return this.honamiStoryBagUpdateContext_;
			}
			set
			{
				this.honamiStoryBagUpdateContext_ = value;
			}
		}

		// Token: 0x0600AC43 RID: 44099 RVA: 0x0019E25F File Offset: 0x0019C45F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryDiscardItemRequest);
		}

		// Token: 0x0600AC44 RID: 44100 RVA: 0x0019E26D File Offset: 0x0019C46D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryDiscardItemRequest other)
		{
			return other != null && (other == this || (object.Equals(this.HonamiStoryBagUpdateContext, other.HonamiStoryBagUpdateContext) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AC45 RID: 44101 RVA: 0x0019E2A0 File Offset: 0x0019C4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.honamiStoryBagUpdateContext_ != null)
			{
				num ^= this.HonamiStoryBagUpdateContext.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AC46 RID: 44102 RVA: 0x0019E2DC File Offset: 0x0019C4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AC47 RID: 44103 RVA: 0x0019E2E9 File Offset: 0x0019C4E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AC48 RID: 44104 RVA: 0x0019E2F2 File Offset: 0x0019C4F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.honamiStoryBagUpdateContext_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.HonamiStoryBagUpdateContext);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AC49 RID: 44105 RVA: 0x0019E324 File Offset: 0x0019C524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.honamiStoryBagUpdateContext_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HonamiStoryBagUpdateContext);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AC4A RID: 44106 RVA: 0x0019E364 File Offset: 0x0019C564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryDiscardItemRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.honamiStoryBagUpdateContext_ != null)
			{
				if (this.honamiStoryBagUpdateContext_ == null)
				{
					this.HonamiStoryBagUpdateContext = new HonamiStoryBagUpdateContext();
				}
				this.HonamiStoryBagUpdateContext.MergeFrom(other.HonamiStoryBagUpdateContext);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AC4B RID: 44107 RVA: 0x0019E3B8 File Offset: 0x0019C5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AC4C RID: 44108 RVA: 0x0019E3C4 File Offset: 0x0019C5C4
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.honamiStoryBagUpdateContext_ == null)
					{
						this.HonamiStoryBagUpdateContext = new HonamiStoryBagUpdateContext();
					}
					input.ReadMessage(this.HonamiStoryBagUpdateContext);
				}
			}
		}

		// Token: 0x04004E0D RID: 19981
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E0E RID: 19982
		public const int HonamiStoryBagUpdateContextFieldNumber = 9;

		// Token: 0x04004E0F RID: 19983
		private HonamiStoryBagUpdateContext honamiStoryBagUpdateContext_;
	}
}
