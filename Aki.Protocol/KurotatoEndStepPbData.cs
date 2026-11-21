using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000885 RID: 2181
	public sealed class KurotatoEndStepPbData : IMessage<KurotatoEndStepPbData>, IMessage, IEquatable<KurotatoEndStepPbData>, IDeepCloneable<KurotatoEndStepPbData>, IBufferMessage
	{
		// Token: 0x0600C23F RID: 49727 RVA: 0x001CD3BD File Offset: 0x001CB5BD
		[NullableContext(1)]
		public static KurotatoEndStepPbData Create()
		{
			return new KurotatoEndStepPbData();
		}

		// Token: 0x1700273B RID: 10043
		// (get) Token: 0x0600C240 RID: 49728 RVA: 0x001CD3C4 File Offset: 0x001CB5C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700273C RID: 10044
		// (get) Token: 0x0600C241 RID: 49729 RVA: 0x001CD3C7 File Offset: 0x001CB5C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoEndStepPbData.Descriptor;
			}
		}

		// Token: 0x0600C242 RID: 49730 RVA: 0x001CD3CE File Offset: 0x001CB5CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndStepPbData()
		{
		}

		// Token: 0x0600C243 RID: 49731 RVA: 0x001CD3D6 File Offset: 0x001CB5D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndStepPbData(KurotatoEndStepPbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C244 RID: 49732 RVA: 0x001CD3EF File Offset: 0x001CB5EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndStepPbData Clone()
		{
			return new KurotatoEndStepPbData(this);
		}

		// Token: 0x0600C245 RID: 49733 RVA: 0x001CD3F7 File Offset: 0x001CB5F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoEndStepPbData);
		}

		// Token: 0x0600C246 RID: 49734 RVA: 0x001CD405 File Offset: 0x001CB605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoEndStepPbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C247 RID: 49735 RVA: 0x001CD424 File Offset: 0x001CB624
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

		// Token: 0x0600C248 RID: 49736 RVA: 0x001CD44A File Offset: 0x001CB64A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C249 RID: 49737 RVA: 0x001CD457 File Offset: 0x001CB657
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C24A RID: 49738 RVA: 0x001CD460 File Offset: 0x001CB660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C24B RID: 49739 RVA: 0x001CD478 File Offset: 0x001CB678
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

		// Token: 0x0600C24C RID: 49740 RVA: 0x001CD49E File Offset: 0x001CB69E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoEndStepPbData other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C24D RID: 49741 RVA: 0x001CD4BB File Offset: 0x001CB6BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C24E RID: 49742 RVA: 0x001CD4C4 File Offset: 0x001CB6C4
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

		// Token: 0x0400546D RID: 21613
		private UnknownFieldSet _unknownFields;
	}
}
