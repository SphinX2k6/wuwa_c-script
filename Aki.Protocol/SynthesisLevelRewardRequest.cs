using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200137F RID: 4991
	[NetMessage(EMessageId.SynthesisLevelRewardRequest)]
	public sealed class SynthesisLevelRewardRequest : IMessage<SynthesisLevelRewardRequest>, IMessage, IEquatable<SynthesisLevelRewardRequest>, IDeepCloneable<SynthesisLevelRewardRequest>, IBufferMessage
	{
		// Token: 0x0601A935 RID: 108853 RVA: 0x003DF447 File Offset: 0x003DD647
		[NullableContext(1)]
		public static SynthesisLevelRewardRequest Create()
		{
			return new SynthesisLevelRewardRequest();
		}

		// Token: 0x170059FA RID: 23034
		// (get) Token: 0x0601A936 RID: 108854 RVA: 0x003DF44E File Offset: 0x003DD64E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059FB RID: 23035
		// (get) Token: 0x0601A937 RID: 108855 RVA: 0x003DF451 File Offset: 0x003DD651
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SynthesisLevelRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601A938 RID: 108856 RVA: 0x003DF458 File Offset: 0x003DD658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisLevelRewardRequest()
		{
		}

		// Token: 0x0601A939 RID: 108857 RVA: 0x003DF460 File Offset: 0x003DD660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisLevelRewardRequest(SynthesisLevelRewardRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A93A RID: 108858 RVA: 0x003DF479 File Offset: 0x003DD679
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisLevelRewardRequest Clone()
		{
			return new SynthesisLevelRewardRequest(this);
		}

		// Token: 0x0601A93B RID: 108859 RVA: 0x003DF481 File Offset: 0x003DD681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SynthesisLevelRewardRequest);
		}

		// Token: 0x0601A93C RID: 108860 RVA: 0x003DF48F File Offset: 0x003DD68F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SynthesisLevelRewardRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601A93D RID: 108861 RVA: 0x003DF4B0 File Offset: 0x003DD6B0
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

		// Token: 0x0601A93E RID: 108862 RVA: 0x003DF4D6 File Offset: 0x003DD6D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A93F RID: 108863 RVA: 0x003DF4E3 File Offset: 0x003DD6E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A940 RID: 108864 RVA: 0x003DF4EC File Offset: 0x003DD6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A941 RID: 108865 RVA: 0x003DF504 File Offset: 0x003DD704
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

		// Token: 0x0601A942 RID: 108866 RVA: 0x003DF52A File Offset: 0x003DD72A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SynthesisLevelRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A943 RID: 108867 RVA: 0x003DF547 File Offset: 0x003DD747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A944 RID: 108868 RVA: 0x003DF550 File Offset: 0x003DD750
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

		// Token: 0x04009BC6 RID: 39878
		private UnknownFieldSet _unknownFields;
	}
}
