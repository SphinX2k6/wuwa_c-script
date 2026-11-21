using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001015 RID: 4117
	[NetMessage(EMessageId.RogueTowerTrialStartRequest)]
	public sealed class RogueTowerTrialStartRequest : IMessage<RogueTowerTrialStartRequest>, IMessage, IEquatable<RogueTowerTrialStartRequest>, IDeepCloneable<RogueTowerTrialStartRequest>, IBufferMessage
	{
		// Token: 0x06016091 RID: 90257 RVA: 0x003345BD File Offset: 0x003327BD
		[NullableContext(1)]
		public static RogueTowerTrialStartRequest Create()
		{
			return new RogueTowerTrialStartRequest();
		}

		// Token: 0x170049AC RID: 18860
		// (get) Token: 0x06016092 RID: 90258 RVA: 0x003345C4 File Offset: 0x003327C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049AD RID: 18861
		// (get) Token: 0x06016093 RID: 90259 RVA: 0x003345C7 File Offset: 0x003327C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTowerTrialStartRequest.Descriptor;
			}
		}

		// Token: 0x06016094 RID: 90260 RVA: 0x003345CE File Offset: 0x003327CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialStartRequest()
		{
		}

		// Token: 0x06016095 RID: 90261 RVA: 0x003345D6 File Offset: 0x003327D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialStartRequest(RogueTowerTrialStartRequest other) : this()
		{
			this.instId_ = other.instId_;
			this.slotId_ = other.slotId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016096 RID: 90262 RVA: 0x00334607 File Offset: 0x00332807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialStartRequest Clone()
		{
			return new RogueTowerTrialStartRequest(this);
		}

		// Token: 0x170049AE RID: 18862
		// (get) Token: 0x06016097 RID: 90263 RVA: 0x0033460F File Offset: 0x0033280F
		// (set) Token: 0x06016098 RID: 90264 RVA: 0x00334617 File Offset: 0x00332817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x170049AF RID: 18863
		// (get) Token: 0x06016099 RID: 90265 RVA: 0x00334620 File Offset: 0x00332820
		// (set) Token: 0x0601609A RID: 90266 RVA: 0x00334628 File Offset: 0x00332828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SlotId
		{
			get
			{
				return this.slotId_;
			}
			set
			{
				this.slotId_ = value;
			}
		}

		// Token: 0x0601609B RID: 90267 RVA: 0x00334631 File Offset: 0x00332831
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTowerTrialStartRequest);
		}

		// Token: 0x0601609C RID: 90268 RVA: 0x0033463F File Offset: 0x0033283F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTowerTrialStartRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.SlotId == other.SlotId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601609D RID: 90269 RVA: 0x00334680 File Offset: 0x00332880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.SlotId != 0)
			{
				num ^= this.SlotId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601609E RID: 90270 RVA: 0x003346D8 File Offset: 0x003328D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601609F RID: 90271 RVA: 0x003346E5 File Offset: 0x003328E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060160A0 RID: 90272 RVA: 0x003346F0 File Offset: 0x003328F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.InstId);
			}
			if (this.SlotId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.SlotId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060160A1 RID: 90273 RVA: 0x0033474C File Offset: 0x0033294C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.SlotId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SlotId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060160A2 RID: 90274 RVA: 0x003347A4 File Offset: 0x003329A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTowerTrialStartRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.SlotId != 0)
			{
				this.SlotId = other.SlotId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060160A3 RID: 90275 RVA: 0x003347F4 File Offset: 0x003329F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060160A4 RID: 90276 RVA: 0x00334800 File Offset: 0x00332A00
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
				if (num != 24U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SlotId = input.ReadInt32();
					}
				}
				else
				{
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008484 RID: 33924
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008485 RID: 33925
		public const int InstIdFieldNumber = 3;

		// Token: 0x04008486 RID: 33926
		private int instId_;

		// Token: 0x04008487 RID: 33927
		public const int SlotIdFieldNumber = 11;

		// Token: 0x04008488 RID: 33928
		private int slotId_;
	}
}
