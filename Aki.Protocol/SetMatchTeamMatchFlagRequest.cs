using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001211 RID: 4625
	[NetMessage(EMessageId.SetMatchTeamMatchFlagRequest)]
	public sealed class SetMatchTeamMatchFlagRequest : IMessage<SetMatchTeamMatchFlagRequest>, IMessage, IEquatable<SetMatchTeamMatchFlagRequest>, IDeepCloneable<SetMatchTeamMatchFlagRequest>, IBufferMessage
	{
		// Token: 0x06018B45 RID: 101189 RVA: 0x0039A095 File Offset: 0x00398295
		[NullableContext(1)]
		public static SetMatchTeamMatchFlagRequest Create()
		{
			return new SetMatchTeamMatchFlagRequest();
		}

		// Token: 0x1700536B RID: 21355
		// (get) Token: 0x06018B46 RID: 101190 RVA: 0x0039A09C File Offset: 0x0039829C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700536C RID: 21356
		// (get) Token: 0x06018B47 RID: 101191 RVA: 0x0039A09F File Offset: 0x0039829F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetMatchTeamMatchFlagRequest.Descriptor;
			}
		}

		// Token: 0x06018B48 RID: 101192 RVA: 0x0039A0A6 File Offset: 0x003982A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetMatchTeamMatchFlagRequest()
		{
		}

		// Token: 0x06018B49 RID: 101193 RVA: 0x0039A0AE File Offset: 0x003982AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetMatchTeamMatchFlagRequest(SetMatchTeamMatchFlagRequest other) : this()
		{
			this.isMatch_ = other.isMatch_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018B4A RID: 101194 RVA: 0x0039A0D3 File Offset: 0x003982D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetMatchTeamMatchFlagRequest Clone()
		{
			return new SetMatchTeamMatchFlagRequest(this);
		}

		// Token: 0x1700536D RID: 21357
		// (get) Token: 0x06018B4B RID: 101195 RVA: 0x0039A0DB File Offset: 0x003982DB
		// (set) Token: 0x06018B4C RID: 101196 RVA: 0x0039A0E3 File Offset: 0x003982E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsMatch
		{
			get
			{
				return this.isMatch_;
			}
			set
			{
				this.isMatch_ = value;
			}
		}

		// Token: 0x06018B4D RID: 101197 RVA: 0x0039A0EC File Offset: 0x003982EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetMatchTeamMatchFlagRequest);
		}

		// Token: 0x06018B4E RID: 101198 RVA: 0x0039A0FA File Offset: 0x003982FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetMatchTeamMatchFlagRequest other)
		{
			return other != null && (other == this || (this.IsMatch == other.IsMatch && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018B4F RID: 101199 RVA: 0x0039A128 File Offset: 0x00398328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsMatch)
			{
				num ^= this.IsMatch.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018B50 RID: 101200 RVA: 0x0039A167 File Offset: 0x00398367
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018B51 RID: 101201 RVA: 0x0039A174 File Offset: 0x00398374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018B52 RID: 101202 RVA: 0x0039A17D File Offset: 0x0039837D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsMatch)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IsMatch);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018B53 RID: 101203 RVA: 0x0039A1B0 File Offset: 0x003983B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsMatch)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018B54 RID: 101204 RVA: 0x0039A1E2 File Offset: 0x003983E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetMatchTeamMatchFlagRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsMatch)
			{
				this.IsMatch = other.IsMatch;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018B55 RID: 101205 RVA: 0x0039A213 File Offset: 0x00398413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018B56 RID: 101206 RVA: 0x0039A21C File Offset: 0x0039841C
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IsMatch = input.ReadBool();
				}
			}
		}

		// Token: 0x040092AE RID: 37550
		private UnknownFieldSet _unknownFields;

		// Token: 0x040092AF RID: 37551
		public const int IsMatchFieldNumber = 14;

		// Token: 0x040092B0 RID: 37552
		private bool isMatch_;
	}
}
