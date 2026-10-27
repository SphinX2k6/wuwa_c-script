using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010D7 RID: 4311
	[NetMessage(EMessageId.RollBlockExitGamePlayRequest)]
	public sealed class RollBlockExitGamePlayRequest : IMessage<RollBlockExitGamePlayRequest>, IMessage, IEquatable<RollBlockExitGamePlayRequest>, IDeepCloneable<RollBlockExitGamePlayRequest>, IBufferMessage
	{
		// Token: 0x06016FF8 RID: 94200 RVA: 0x003566F1 File Offset: 0x003548F1
		[NullableContext(1)]
		public static RollBlockExitGamePlayRequest Create()
		{
			return new RollBlockExitGamePlayRequest();
		}

		// Token: 0x17004D07 RID: 19719
		// (get) Token: 0x06016FF9 RID: 94201 RVA: 0x003566F8 File Offset: 0x003548F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D08 RID: 19720
		// (get) Token: 0x06016FFA RID: 94202 RVA: 0x003566FB File Offset: 0x003548FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockExitGamePlayRequest.Descriptor;
			}
		}

		// Token: 0x06016FFB RID: 94203 RVA: 0x00356702 File Offset: 0x00354902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockExitGamePlayRequest()
		{
		}

		// Token: 0x06016FFC RID: 94204 RVA: 0x0035670A File Offset: 0x0035490A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockExitGamePlayRequest(RollBlockExitGamePlayRequest other) : this()
		{
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016FFD RID: 94205 RVA: 0x0035672F File Offset: 0x0035492F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockExitGamePlayRequest Clone()
		{
			return new RollBlockExitGamePlayRequest(this);
		}

		// Token: 0x17004D09 RID: 19721
		// (get) Token: 0x06016FFE RID: 94206 RVA: 0x00356737 File Offset: 0x00354937
		// (set) Token: 0x06016FFF RID: 94207 RVA: 0x0035673F File Offset: 0x0035493F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x06017000 RID: 94208 RVA: 0x00356748 File Offset: 0x00354948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockExitGamePlayRequest);
		}

		// Token: 0x06017001 RID: 94209 RVA: 0x00356756 File Offset: 0x00354956
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockExitGamePlayRequest other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017002 RID: 94210 RVA: 0x00356784 File Offset: 0x00354984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017003 RID: 94211 RVA: 0x003567C3 File Offset: 0x003549C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017004 RID: 94212 RVA: 0x003567D0 File Offset: 0x003549D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017005 RID: 94213 RVA: 0x003567D9 File Offset: 0x003549D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017006 RID: 94214 RVA: 0x0035680C File Offset: 0x00354A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017007 RID: 94215 RVA: 0x0035684A File Offset: 0x00354A4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockExitGamePlayRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017008 RID: 94216 RVA: 0x0035687B File Offset: 0x00354A7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017009 RID: 94217 RVA: 0x00356884 File Offset: 0x00354A84
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040088EB RID: 35051
		private UnknownFieldSet _unknownFields;

		// Token: 0x040088EC RID: 35052
		public const int IncIdFieldNumber = 12;

		// Token: 0x040088ED RID: 35053
		private int incId_;
	}
}
