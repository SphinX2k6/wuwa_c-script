using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E8B RID: 3723
	[NetMessage(EMessageId.RealmBetweenFullRewardRequest)]
	public sealed class RealmBetweenFullRewardRequest : IMessage<RealmBetweenFullRewardRequest>, IMessage, IEquatable<RealmBetweenFullRewardRequest>, IDeepCloneable<RealmBetweenFullRewardRequest>, IBufferMessage
	{
		// Token: 0x06014046 RID: 81990 RVA: 0x002EAB55 File Offset: 0x002E8D55
		[NullableContext(1)]
		public static RealmBetweenFullRewardRequest Create()
		{
			return new RealmBetweenFullRewardRequest();
		}

		// Token: 0x1700429B RID: 17051
		// (get) Token: 0x06014047 RID: 81991 RVA: 0x002EAB5C File Offset: 0x002E8D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700429C RID: 17052
		// (get) Token: 0x06014048 RID: 81992 RVA: 0x002EAB5F File Offset: 0x002E8D5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RealmBetweenFullRewardRequest.Descriptor;
			}
		}

		// Token: 0x06014049 RID: 81993 RVA: 0x002EAB66 File Offset: 0x002E8D66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenFullRewardRequest()
		{
		}

		// Token: 0x0601404A RID: 81994 RVA: 0x002EAB6E File Offset: 0x002E8D6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenFullRewardRequest(RealmBetweenFullRewardRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601404B RID: 81995 RVA: 0x002EAB87 File Offset: 0x002E8D87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenFullRewardRequest Clone()
		{
			return new RealmBetweenFullRewardRequest(this);
		}

		// Token: 0x0601404C RID: 81996 RVA: 0x002EAB8F File Offset: 0x002E8D8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RealmBetweenFullRewardRequest);
		}

		// Token: 0x0601404D RID: 81997 RVA: 0x002EAB9D File Offset: 0x002E8D9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RealmBetweenFullRewardRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601404E RID: 81998 RVA: 0x002EABBC File Offset: 0x002E8DBC
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

		// Token: 0x0601404F RID: 81999 RVA: 0x002EABE2 File Offset: 0x002E8DE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014050 RID: 82000 RVA: 0x002EABEF File Offset: 0x002E8DEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014051 RID: 82001 RVA: 0x002EABF8 File Offset: 0x002E8DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014052 RID: 82002 RVA: 0x002EAC10 File Offset: 0x002E8E10
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

		// Token: 0x06014053 RID: 82003 RVA: 0x002EAC36 File Offset: 0x002E8E36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RealmBetweenFullRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014054 RID: 82004 RVA: 0x002EAC53 File Offset: 0x002E8E53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014055 RID: 82005 RVA: 0x002EAC5C File Offset: 0x002E8E5C
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

		// Token: 0x04007A9B RID: 31387
		private UnknownFieldSet _unknownFields;
	}
}
