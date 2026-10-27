using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011D7 RID: 4567
	[NetMessage(EMessageId.SetMatchTeamMatchFlagRequest)]
	public sealed class SetMatchTeamMatchFlagRequest : IMessage<SetMatchTeamMatchFlagRequest>, IMessage, IEquatable<SetMatchTeamMatchFlagRequest>, IDeepCloneable<SetMatchTeamMatchFlagRequest>, IBufferMessage
	{
		// Token: 0x060185A4 RID: 99748 RVA: 0x0038AD65 File Offset: 0x00388F65
		[NullableContext(1)]
		public static SetMatchTeamMatchFlagRequest Create()
		{
			return new SetMatchTeamMatchFlagRequest();
		}

		// Token: 0x170051FF RID: 20991
		// (get) Token: 0x060185A5 RID: 99749 RVA: 0x0038AD6C File Offset: 0x00388F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005200 RID: 20992
		// (get) Token: 0x060185A6 RID: 99750 RVA: 0x0038AD6F File Offset: 0x00388F6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetMatchTeamMatchFlagRequest.Descriptor;
			}
		}

		// Token: 0x060185A7 RID: 99751 RVA: 0x0038AD76 File Offset: 0x00388F76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetMatchTeamMatchFlagRequest()
		{
		}

		// Token: 0x060185A8 RID: 99752 RVA: 0x0038AD7E File Offset: 0x00388F7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetMatchTeamMatchFlagRequest(SetMatchTeamMatchFlagRequest other) : this()
		{
			this.isMatch_ = other.isMatch_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060185A9 RID: 99753 RVA: 0x0038ADA3 File Offset: 0x00388FA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetMatchTeamMatchFlagRequest Clone()
		{
			return new SetMatchTeamMatchFlagRequest(this);
		}

		// Token: 0x17005201 RID: 20993
		// (get) Token: 0x060185AA RID: 99754 RVA: 0x0038ADAB File Offset: 0x00388FAB
		// (set) Token: 0x060185AB RID: 99755 RVA: 0x0038ADB3 File Offset: 0x00388FB3
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

		// Token: 0x060185AC RID: 99756 RVA: 0x0038ADBC File Offset: 0x00388FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetMatchTeamMatchFlagRequest);
		}

		// Token: 0x060185AD RID: 99757 RVA: 0x0038ADCA File Offset: 0x00388FCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetMatchTeamMatchFlagRequest other)
		{
			return other != null && (other == this || (this.IsMatch == other.IsMatch && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060185AE RID: 99758 RVA: 0x0038ADF8 File Offset: 0x00388FF8
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

		// Token: 0x060185AF RID: 99759 RVA: 0x0038AE37 File Offset: 0x00389037
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060185B0 RID: 99760 RVA: 0x0038AE44 File Offset: 0x00389044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060185B1 RID: 99761 RVA: 0x0038AE4D File Offset: 0x0038904D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsMatch)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsMatch);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060185B2 RID: 99762 RVA: 0x0038AE80 File Offset: 0x00389080
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

		// Token: 0x060185B3 RID: 99763 RVA: 0x0038AEB2 File Offset: 0x003890B2
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

		// Token: 0x060185B4 RID: 99764 RVA: 0x0038AEE3 File Offset: 0x003890E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060185B5 RID: 99765 RVA: 0x0038AEEC File Offset: 0x003890EC
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IsMatch = input.ReadBool();
				}
			}
		}

		// Token: 0x0400901B RID: 36891
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400901C RID: 36892
		public const int IsMatchFieldNumber = 11;

		// Token: 0x0400901D RID: 36893
		private bool isMatch_;
	}
}
