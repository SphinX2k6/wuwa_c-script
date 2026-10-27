using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000896 RID: 2198
	public sealed class KurotatoEndStepPbData : IMessage<KurotatoEndStepPbData>, IMessage, IEquatable<KurotatoEndStepPbData>, IDeepCloneable<KurotatoEndStepPbData>, IBufferMessage
	{
		// Token: 0x0600C35B RID: 50011 RVA: 0x001CF6A5 File Offset: 0x001CD8A5
		[NullableContext(1)]
		public static KurotatoEndStepPbData Create()
		{
			return new KurotatoEndStepPbData();
		}

		// Token: 0x1700277A RID: 10106
		// (get) Token: 0x0600C35C RID: 50012 RVA: 0x001CF6AC File Offset: 0x001CD8AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700277B RID: 10107
		// (get) Token: 0x0600C35D RID: 50013 RVA: 0x001CF6AF File Offset: 0x001CD8AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoEndStepPbData.Descriptor;
			}
		}

		// Token: 0x0600C35E RID: 50014 RVA: 0x001CF6B6 File Offset: 0x001CD8B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndStepPbData()
		{
		}

		// Token: 0x0600C35F RID: 50015 RVA: 0x001CF6BE File Offset: 0x001CD8BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndStepPbData(KurotatoEndStepPbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C360 RID: 50016 RVA: 0x001CF6D7 File Offset: 0x001CD8D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndStepPbData Clone()
		{
			return new KurotatoEndStepPbData(this);
		}

		// Token: 0x0600C361 RID: 50017 RVA: 0x001CF6DF File Offset: 0x001CD8DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoEndStepPbData);
		}

		// Token: 0x0600C362 RID: 50018 RVA: 0x001CF6ED File Offset: 0x001CD8ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoEndStepPbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C363 RID: 50019 RVA: 0x001CF70C File Offset: 0x001CD90C
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

		// Token: 0x0600C364 RID: 50020 RVA: 0x001CF732 File Offset: 0x001CD932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C365 RID: 50021 RVA: 0x001CF73F File Offset: 0x001CD93F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C366 RID: 50022 RVA: 0x001CF748 File Offset: 0x001CD948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C367 RID: 50023 RVA: 0x001CF760 File Offset: 0x001CD960
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

		// Token: 0x0600C368 RID: 50024 RVA: 0x001CF786 File Offset: 0x001CD986
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

		// Token: 0x0600C369 RID: 50025 RVA: 0x001CF7A3 File Offset: 0x001CD9A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C36A RID: 50026 RVA: 0x001CF7AC File Offset: 0x001CD9AC
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

		// Token: 0x04005466 RID: 21606
		private UnknownFieldSet _unknownFields;
	}
}
