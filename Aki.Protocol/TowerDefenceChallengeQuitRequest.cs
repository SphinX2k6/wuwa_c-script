using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200139B RID: 5019
	[NetMessage(EMessageId.TowerDefenceChallengeQuitRequest)]
	public sealed class TowerDefenceChallengeQuitRequest : IMessage<TowerDefenceChallengeQuitRequest>, IMessage, IEquatable<TowerDefenceChallengeQuitRequest>, IDeepCloneable<TowerDefenceChallengeQuitRequest>, IBufferMessage
	{
		// Token: 0x0601AA1C RID: 109084 RVA: 0x003DCF1E File Offset: 0x003DB11E
		[NullableContext(1)]
		public static TowerDefenceChallengeQuitRequest Create()
		{
			return new TowerDefenceChallengeQuitRequest();
		}

		// Token: 0x170059CC RID: 22988
		// (get) Token: 0x0601AA1D RID: 109085 RVA: 0x003DCF25 File Offset: 0x003DB125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059CD RID: 22989
		// (get) Token: 0x0601AA1E RID: 109086 RVA: 0x003DCF28 File Offset: 0x003DB128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceChallengeQuitRequest.Descriptor;
			}
		}

		// Token: 0x0601AA1F RID: 109087 RVA: 0x003DCF2F File Offset: 0x003DB12F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceChallengeQuitRequest()
		{
		}

		// Token: 0x0601AA20 RID: 109088 RVA: 0x003DCF37 File Offset: 0x003DB137
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceChallengeQuitRequest(TowerDefenceChallengeQuitRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AA21 RID: 109089 RVA: 0x003DCF50 File Offset: 0x003DB150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceChallengeQuitRequest Clone()
		{
			return new TowerDefenceChallengeQuitRequest(this);
		}

		// Token: 0x0601AA22 RID: 109090 RVA: 0x003DCF58 File Offset: 0x003DB158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceChallengeQuitRequest);
		}

		// Token: 0x0601AA23 RID: 109091 RVA: 0x003DCF66 File Offset: 0x003DB166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceChallengeQuitRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601AA24 RID: 109092 RVA: 0x003DCF84 File Offset: 0x003DB184
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

		// Token: 0x0601AA25 RID: 109093 RVA: 0x003DCFAA File Offset: 0x003DB1AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AA26 RID: 109094 RVA: 0x003DCFB7 File Offset: 0x003DB1B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AA27 RID: 109095 RVA: 0x003DCFC0 File Offset: 0x003DB1C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AA28 RID: 109096 RVA: 0x003DCFD8 File Offset: 0x003DB1D8
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

		// Token: 0x0601AA29 RID: 109097 RVA: 0x003DCFFE File Offset: 0x003DB1FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefenceChallengeQuitRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AA2A RID: 109098 RVA: 0x003DD01B File Offset: 0x003DB21B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AA2B RID: 109099 RVA: 0x003DD024 File Offset: 0x003DB224
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

		// Token: 0x04009ABD RID: 39613
		private UnknownFieldSet _unknownFields;
	}
}
