using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001034 RID: 4148
	[NetMessage(EMessageId.RogueWeeklyResultRequest)]
	public sealed class RogueWeeklyResultRequest : IMessage<RogueWeeklyResultRequest>, IMessage, IEquatable<RogueWeeklyResultRequest>, IDeepCloneable<RogueWeeklyResultRequest>, IBufferMessage
	{
		// Token: 0x0601631E RID: 90910 RVA: 0x0033A113 File Offset: 0x00338313
		[NullableContext(1)]
		public static RogueWeeklyResultRequest Create()
		{
			return new RogueWeeklyResultRequest();
		}

		// Token: 0x17004A3A RID: 19002
		// (get) Token: 0x0601631F RID: 90911 RVA: 0x0033A11A File Offset: 0x0033831A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A3B RID: 19003
		// (get) Token: 0x06016320 RID: 90912 RVA: 0x0033A11D File Offset: 0x0033831D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyResultRequest.Descriptor;
			}
		}

		// Token: 0x06016321 RID: 90913 RVA: 0x0033A124 File Offset: 0x00338324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyResultRequest()
		{
		}

		// Token: 0x06016322 RID: 90914 RVA: 0x0033A12C File Offset: 0x0033832C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyResultRequest(RogueWeeklyResultRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016323 RID: 90915 RVA: 0x0033A145 File Offset: 0x00338345
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyResultRequest Clone()
		{
			return new RogueWeeklyResultRequest(this);
		}

		// Token: 0x06016324 RID: 90916 RVA: 0x0033A14D File Offset: 0x0033834D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyResultRequest);
		}

		// Token: 0x06016325 RID: 90917 RVA: 0x0033A15B File Offset: 0x0033835B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyResultRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06016326 RID: 90918 RVA: 0x0033A17C File Offset: 0x0033837C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016327 RID: 90919 RVA: 0x0033A1A2 File Offset: 0x003383A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016328 RID: 90920 RVA: 0x0033A1AF File Offset: 0x003383AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016329 RID: 90921 RVA: 0x0033A1B8 File Offset: 0x003383B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601632A RID: 90922 RVA: 0x0033A1D0 File Offset: 0x003383D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601632B RID: 90923 RVA: 0x0033A1F6 File Offset: 0x003383F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyResultRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601632C RID: 90924 RVA: 0x0033A213 File Offset: 0x00338413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601632D RID: 90925 RVA: 0x0033A21C File Offset: 0x0033841C
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008545 RID: 34117
		private UnknownFieldSet _unknownFields;
	}
}
