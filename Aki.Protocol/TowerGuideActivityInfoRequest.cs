using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013BC RID: 5052
	[NetMessage(EMessageId.TowerGuideActivityInfoRequest)]
	public sealed class TowerGuideActivityInfoRequest : IMessage<TowerGuideActivityInfoRequest>, IMessage, IEquatable<TowerGuideActivityInfoRequest>, IDeepCloneable<TowerGuideActivityInfoRequest>, IBufferMessage
	{
		// Token: 0x0601ACD2 RID: 109778 RVA: 0x003E2EC1 File Offset: 0x003E10C1
		[NullableContext(1)]
		public static TowerGuideActivityInfoRequest Create()
		{
			return new TowerGuideActivityInfoRequest();
		}

		// Token: 0x17005A65 RID: 23141
		// (get) Token: 0x0601ACD3 RID: 109779 RVA: 0x003E2EC8 File Offset: 0x003E10C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A66 RID: 23142
		// (get) Token: 0x0601ACD4 RID: 109780 RVA: 0x003E2ECB File Offset: 0x003E10CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerGuideActivityInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601ACD5 RID: 109781 RVA: 0x003E2ED2 File Offset: 0x003E10D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerGuideActivityInfoRequest()
		{
		}

		// Token: 0x0601ACD6 RID: 109782 RVA: 0x003E2EDA File Offset: 0x003E10DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerGuideActivityInfoRequest(TowerGuideActivityInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601ACD7 RID: 109783 RVA: 0x003E2EF3 File Offset: 0x003E10F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerGuideActivityInfoRequest Clone()
		{
			return new TowerGuideActivityInfoRequest(this);
		}

		// Token: 0x0601ACD8 RID: 109784 RVA: 0x003E2EFB File Offset: 0x003E10FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerGuideActivityInfoRequest);
		}

		// Token: 0x0601ACD9 RID: 109785 RVA: 0x003E2F09 File Offset: 0x003E1109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerGuideActivityInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601ACDA RID: 109786 RVA: 0x003E2F28 File Offset: 0x003E1128
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

		// Token: 0x0601ACDB RID: 109787 RVA: 0x003E2F4E File Offset: 0x003E114E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601ACDC RID: 109788 RVA: 0x003E2F5B File Offset: 0x003E115B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601ACDD RID: 109789 RVA: 0x003E2F64 File Offset: 0x003E1164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601ACDE RID: 109790 RVA: 0x003E2F7C File Offset: 0x003E117C
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

		// Token: 0x0601ACDF RID: 109791 RVA: 0x003E2FA2 File Offset: 0x003E11A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerGuideActivityInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601ACE0 RID: 109792 RVA: 0x003E2FBF File Offset: 0x003E11BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601ACE1 RID: 109793 RVA: 0x003E2FC8 File Offset: 0x003E11C8
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

		// Token: 0x04009B98 RID: 39832
		private UnknownFieldSet _unknownFields;
	}
}
