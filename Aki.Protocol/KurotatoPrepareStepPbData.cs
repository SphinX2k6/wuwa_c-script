using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000899 RID: 2201
	public sealed class KurotatoPrepareStepPbData : IMessage<KurotatoPrepareStepPbData>, IMessage, IEquatable<KurotatoPrepareStepPbData>, IDeepCloneable<KurotatoPrepareStepPbData>, IBufferMessage
	{
		// Token: 0x0600C3DE RID: 50142 RVA: 0x001D0A98 File Offset: 0x001CEC98
		[NullableContext(1)]
		public static KurotatoPrepareStepPbData Create()
		{
			return new KurotatoPrepareStepPbData();
		}

		// Token: 0x17002793 RID: 10131
		// (get) Token: 0x0600C3DF RID: 50143 RVA: 0x001D0A9F File Offset: 0x001CEC9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002794 RID: 10132
		// (get) Token: 0x0600C3E0 RID: 50144 RVA: 0x001D0AA2 File Offset: 0x001CECA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoPrepareStepPbData.Descriptor;
			}
		}

		// Token: 0x0600C3E1 RID: 50145 RVA: 0x001D0AA9 File Offset: 0x001CECA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoPrepareStepPbData()
		{
		}

		// Token: 0x0600C3E2 RID: 50146 RVA: 0x001D0AB1 File Offset: 0x001CECB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoPrepareStepPbData(KurotatoPrepareStepPbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C3E3 RID: 50147 RVA: 0x001D0ACA File Offset: 0x001CECCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoPrepareStepPbData Clone()
		{
			return new KurotatoPrepareStepPbData(this);
		}

		// Token: 0x0600C3E4 RID: 50148 RVA: 0x001D0AD2 File Offset: 0x001CECD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoPrepareStepPbData);
		}

		// Token: 0x0600C3E5 RID: 50149 RVA: 0x001D0AE0 File Offset: 0x001CECE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoPrepareStepPbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C3E6 RID: 50150 RVA: 0x001D0B00 File Offset: 0x001CED00
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

		// Token: 0x0600C3E7 RID: 50151 RVA: 0x001D0B26 File Offset: 0x001CED26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C3E8 RID: 50152 RVA: 0x001D0B33 File Offset: 0x001CED33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C3E9 RID: 50153 RVA: 0x001D0B3C File Offset: 0x001CED3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C3EA RID: 50154 RVA: 0x001D0B54 File Offset: 0x001CED54
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

		// Token: 0x0600C3EB RID: 50155 RVA: 0x001D0B7A File Offset: 0x001CED7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoPrepareStepPbData other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C3EC RID: 50156 RVA: 0x001D0B97 File Offset: 0x001CED97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C3ED RID: 50157 RVA: 0x001D0BA0 File Offset: 0x001CEDA0
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

		// Token: 0x040054E3 RID: 21731
		private UnknownFieldSet _unknownFields;
	}
}
