using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007D9 RID: 2009
	[NetMessage(EMessageId.InfrRoadBuildRequest)]
	public sealed class InfrRoadBuildRequest : IMessage<InfrRoadBuildRequest>, IMessage, IEquatable<InfrRoadBuildRequest>, IDeepCloneable<InfrRoadBuildRequest>, IBufferMessage
	{
		// Token: 0x0600B4A3 RID: 46243 RVA: 0x001AFDD4 File Offset: 0x001ADFD4
		[NullableContext(1)]
		public static InfrRoadBuildRequest Create()
		{
			return new InfrRoadBuildRequest();
		}

		// Token: 0x17002468 RID: 9320
		// (get) Token: 0x0600B4A4 RID: 46244 RVA: 0x001AFDDB File Offset: 0x001ADFDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002469 RID: 9321
		// (get) Token: 0x0600B4A5 RID: 46245 RVA: 0x001AFDDE File Offset: 0x001ADFDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrRoadBuildRequest.Descriptor;
			}
		}

		// Token: 0x0600B4A6 RID: 46246 RVA: 0x001AFDE5 File Offset: 0x001ADFE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrRoadBuildRequest()
		{
		}

		// Token: 0x0600B4A7 RID: 46247 RVA: 0x001AFDED File Offset: 0x001ADFED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrRoadBuildRequest(InfrRoadBuildRequest other) : this()
		{
			this.roadId_ = other.roadId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B4A8 RID: 46248 RVA: 0x001AFE12 File Offset: 0x001AE012
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrRoadBuildRequest Clone()
		{
			return new InfrRoadBuildRequest(this);
		}

		// Token: 0x1700246A RID: 9322
		// (get) Token: 0x0600B4A9 RID: 46249 RVA: 0x001AFE1A File Offset: 0x001AE01A
		// (set) Token: 0x0600B4AA RID: 46250 RVA: 0x001AFE22 File Offset: 0x001AE022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoadId
		{
			get
			{
				return this.roadId_;
			}
			set
			{
				this.roadId_ = value;
			}
		}

		// Token: 0x0600B4AB RID: 46251 RVA: 0x001AFE2B File Offset: 0x001AE02B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrRoadBuildRequest);
		}

		// Token: 0x0600B4AC RID: 46252 RVA: 0x001AFE39 File Offset: 0x001AE039
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrRoadBuildRequest other)
		{
			return other != null && (other == this || (this.RoadId == other.RoadId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B4AD RID: 46253 RVA: 0x001AFE68 File Offset: 0x001AE068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoadId != 0)
			{
				num ^= this.RoadId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B4AE RID: 46254 RVA: 0x001AFEA7 File Offset: 0x001AE0A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B4AF RID: 46255 RVA: 0x001AFEB4 File Offset: 0x001AE0B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B4B0 RID: 46256 RVA: 0x001AFEBD File Offset: 0x001AE0BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoadId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.RoadId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B4B1 RID: 46257 RVA: 0x001AFEF0 File Offset: 0x001AE0F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoadId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoadId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B4B2 RID: 46258 RVA: 0x001AFF2E File Offset: 0x001AE12E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrRoadBuildRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoadId != 0)
			{
				this.RoadId = other.RoadId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B4B3 RID: 46259 RVA: 0x001AFF5F File Offset: 0x001AE15F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B4B4 RID: 46260 RVA: 0x001AFF68 File Offset: 0x001AE168
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RoadId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040050A5 RID: 20645
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050A6 RID: 20646
		public const int RoadIdFieldNumber = 9;

		// Token: 0x040050A7 RID: 20647
		private int roadId_;
	}
}
