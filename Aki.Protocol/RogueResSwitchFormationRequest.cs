using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001008 RID: 4104
	[NetMessage(EMessageId.RogueResSwitchFormationRequest)]
	public sealed class RogueResSwitchFormationRequest : IMessage<RogueResSwitchFormationRequest>, IMessage, IEquatable<RogueResSwitchFormationRequest>, IDeepCloneable<RogueResSwitchFormationRequest>, IBufferMessage
	{
		// Token: 0x06015F31 RID: 89905 RVA: 0x003312E9 File Offset: 0x0032F4E9
		[NullableContext(1)]
		public static RogueResSwitchFormationRequest Create()
		{
			return new RogueResSwitchFormationRequest();
		}

		// Token: 0x17004961 RID: 18785
		// (get) Token: 0x06015F32 RID: 89906 RVA: 0x003312F0 File Offset: 0x0032F4F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004962 RID: 18786
		// (get) Token: 0x06015F33 RID: 89907 RVA: 0x003312F3 File Offset: 0x0032F4F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResSwitchFormationRequest.Descriptor;
			}
		}

		// Token: 0x06015F34 RID: 89908 RVA: 0x003312FA File Offset: 0x0032F4FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResSwitchFormationRequest()
		{
		}

		// Token: 0x06015F35 RID: 89909 RVA: 0x00331302 File Offset: 0x0032F502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResSwitchFormationRequest(RogueResSwitchFormationRequest other) : this()
		{
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015F36 RID: 89910 RVA: 0x00331327 File Offset: 0x0032F527
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResSwitchFormationRequest Clone()
		{
			return new RogueResSwitchFormationRequest(this);
		}

		// Token: 0x17004963 RID: 18787
		// (get) Token: 0x06015F37 RID: 89911 RVA: 0x0033132F File Offset: 0x0032F52F
		// (set) Token: 0x06015F38 RID: 89912 RVA: 0x00331337 File Offset: 0x0032F537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x06015F39 RID: 89913 RVA: 0x00331340 File Offset: 0x0032F540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResSwitchFormationRequest);
		}

		// Token: 0x06015F3A RID: 89914 RVA: 0x0033134E File Offset: 0x0032F54E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResSwitchFormationRequest other)
		{
			return other != null && (other == this || (this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015F3B RID: 89915 RVA: 0x0033137C File Offset: 0x0032F57C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015F3C RID: 89916 RVA: 0x003313BB File Offset: 0x0032F5BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015F3D RID: 89917 RVA: 0x003313C8 File Offset: 0x0032F5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015F3E RID: 89918 RVA: 0x003313D1 File Offset: 0x0032F5D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015F3F RID: 89919 RVA: 0x00331404 File Offset: 0x0032F604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015F40 RID: 89920 RVA: 0x00331442 File Offset: 0x0032F642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResSwitchFormationRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015F41 RID: 89921 RVA: 0x00331473 File Offset: 0x0032F673
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015F42 RID: 89922 RVA: 0x0033147C File Offset: 0x0032F67C
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Index = input.ReadInt32();
				}
			}
		}

		// Token: 0x040083C5 RID: 33733
		private UnknownFieldSet _unknownFields;

		// Token: 0x040083C6 RID: 33734
		public const int IndexFieldNumber = 4;

		// Token: 0x040083C7 RID: 33735
		private int index_;
	}
}
