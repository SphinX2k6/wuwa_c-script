using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007FC RID: 2044
	[NetMessage(EMessageId.InfrV2LevelUpRequest)]
	public sealed class InfrV2LevelUpRequest : IMessage<InfrV2LevelUpRequest>, IMessage, IEquatable<InfrV2LevelUpRequest>, IDeepCloneable<InfrV2LevelUpRequest>, IBufferMessage
	{
		// Token: 0x0600B71A RID: 46874 RVA: 0x001B4C73 File Offset: 0x001B2E73
		[NullableContext(1)]
		public static InfrV2LevelUpRequest Create()
		{
			return new InfrV2LevelUpRequest();
		}

		// Token: 0x170024E9 RID: 9449
		// (get) Token: 0x0600B71B RID: 46875 RVA: 0x001B4C7A File Offset: 0x001B2E7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024EA RID: 9450
		// (get) Token: 0x0600B71C RID: 46876 RVA: 0x001B4C7D File Offset: 0x001B2E7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2LevelUpRequest.Descriptor;
			}
		}

		// Token: 0x0600B71D RID: 46877 RVA: 0x001B4C84 File Offset: 0x001B2E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2LevelUpRequest()
		{
		}

		// Token: 0x0600B71E RID: 46878 RVA: 0x001B4C8C File Offset: 0x001B2E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2LevelUpRequest(InfrV2LevelUpRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B71F RID: 46879 RVA: 0x001B4CA5 File Offset: 0x001B2EA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2LevelUpRequest Clone()
		{
			return new InfrV2LevelUpRequest(this);
		}

		// Token: 0x0600B720 RID: 46880 RVA: 0x001B4CAD File Offset: 0x001B2EAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2LevelUpRequest);
		}

		// Token: 0x0600B721 RID: 46881 RVA: 0x001B4CBB File Offset: 0x001B2EBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2LevelUpRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600B722 RID: 46882 RVA: 0x001B4CDC File Offset: 0x001B2EDC
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

		// Token: 0x0600B723 RID: 46883 RVA: 0x001B4D02 File Offset: 0x001B2F02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B724 RID: 46884 RVA: 0x001B4D0F File Offset: 0x001B2F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B725 RID: 46885 RVA: 0x001B4D18 File Offset: 0x001B2F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B726 RID: 46886 RVA: 0x001B4D30 File Offset: 0x001B2F30
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

		// Token: 0x0600B727 RID: 46887 RVA: 0x001B4D56 File Offset: 0x001B2F56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2LevelUpRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B728 RID: 46888 RVA: 0x001B4D73 File Offset: 0x001B2F73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B729 RID: 46889 RVA: 0x001B4D7C File Offset: 0x001B2F7C
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

		// Token: 0x040050EF RID: 20719
		private UnknownFieldSet _unknownFields;
	}
}
