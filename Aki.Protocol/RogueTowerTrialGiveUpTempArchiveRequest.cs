using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001009 RID: 4105
	[NetMessage(EMessageId.RogueTowerTrialGiveUpTempArchiveRequest)]
	public sealed class RogueTowerTrialGiveUpTempArchiveRequest : IMessage<RogueTowerTrialGiveUpTempArchiveRequest>, IMessage, IEquatable<RogueTowerTrialGiveUpTempArchiveRequest>, IDeepCloneable<RogueTowerTrialGiveUpTempArchiveRequest>, IBufferMessage
	{
		// Token: 0x06015FAD RID: 90029 RVA: 0x00332A73 File Offset: 0x00330C73
		[NullableContext(1)]
		public static RogueTowerTrialGiveUpTempArchiveRequest Create()
		{
			return new RogueTowerTrialGiveUpTempArchiveRequest();
		}

		// Token: 0x17004982 RID: 18818
		// (get) Token: 0x06015FAE RID: 90030 RVA: 0x00332A7A File Offset: 0x00330C7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004983 RID: 18819
		// (get) Token: 0x06015FAF RID: 90031 RVA: 0x00332A7D File Offset: 0x00330C7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTowerTrialGiveUpTempArchiveRequest.Descriptor;
			}
		}

		// Token: 0x06015FB0 RID: 90032 RVA: 0x00332A84 File Offset: 0x00330C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialGiveUpTempArchiveRequest()
		{
		}

		// Token: 0x06015FB1 RID: 90033 RVA: 0x00332A8C File Offset: 0x00330C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialGiveUpTempArchiveRequest(RogueTowerTrialGiveUpTempArchiveRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015FB2 RID: 90034 RVA: 0x00332AA5 File Offset: 0x00330CA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialGiveUpTempArchiveRequest Clone()
		{
			return new RogueTowerTrialGiveUpTempArchiveRequest(this);
		}

		// Token: 0x06015FB3 RID: 90035 RVA: 0x00332AAD File Offset: 0x00330CAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTowerTrialGiveUpTempArchiveRequest);
		}

		// Token: 0x06015FB4 RID: 90036 RVA: 0x00332ABB File Offset: 0x00330CBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTowerTrialGiveUpTempArchiveRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06015FB5 RID: 90037 RVA: 0x00332ADC File Offset: 0x00330CDC
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

		// Token: 0x06015FB6 RID: 90038 RVA: 0x00332B02 File Offset: 0x00330D02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015FB7 RID: 90039 RVA: 0x00332B0F File Offset: 0x00330D0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015FB8 RID: 90040 RVA: 0x00332B18 File Offset: 0x00330D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015FB9 RID: 90041 RVA: 0x00332B30 File Offset: 0x00330D30
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

		// Token: 0x06015FBA RID: 90042 RVA: 0x00332B56 File Offset: 0x00330D56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTowerTrialGiveUpTempArchiveRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015FBB RID: 90043 RVA: 0x00332B73 File Offset: 0x00330D73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015FBC RID: 90044 RVA: 0x00332B7C File Offset: 0x00330D7C
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

		// Token: 0x04008452 RID: 33874
		private UnknownFieldSet _unknownFields;
	}
}
