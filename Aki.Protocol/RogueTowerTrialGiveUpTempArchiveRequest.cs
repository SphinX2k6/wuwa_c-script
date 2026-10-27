using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001019 RID: 4121
	[NetMessage(EMessageId.RogueTowerTrialGiveUpTempArchiveRequest)]
	public sealed class RogueTowerTrialGiveUpTempArchiveRequest : IMessage<RogueTowerTrialGiveUpTempArchiveRequest>, IMessage, IEquatable<RogueTowerTrialGiveUpTempArchiveRequest>, IDeepCloneable<RogueTowerTrialGiveUpTempArchiveRequest>, IBufferMessage
	{
		// Token: 0x06016092 RID: 90258 RVA: 0x0033412F File Offset: 0x0033232F
		[NullableContext(1)]
		public static RogueTowerTrialGiveUpTempArchiveRequest Create()
		{
			return new RogueTowerTrialGiveUpTempArchiveRequest();
		}

		// Token: 0x170049AC RID: 18860
		// (get) Token: 0x06016093 RID: 90259 RVA: 0x00334136 File Offset: 0x00332336
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049AD RID: 18861
		// (get) Token: 0x06016094 RID: 90260 RVA: 0x00334139 File Offset: 0x00332339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTowerTrialGiveUpTempArchiveRequest.Descriptor;
			}
		}

		// Token: 0x06016095 RID: 90261 RVA: 0x00334140 File Offset: 0x00332340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialGiveUpTempArchiveRequest()
		{
		}

		// Token: 0x06016096 RID: 90262 RVA: 0x00334148 File Offset: 0x00332348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialGiveUpTempArchiveRequest(RogueTowerTrialGiveUpTempArchiveRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016097 RID: 90263 RVA: 0x00334161 File Offset: 0x00332361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialGiveUpTempArchiveRequest Clone()
		{
			return new RogueTowerTrialGiveUpTempArchiveRequest(this);
		}

		// Token: 0x06016098 RID: 90264 RVA: 0x00334169 File Offset: 0x00332369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTowerTrialGiveUpTempArchiveRequest);
		}

		// Token: 0x06016099 RID: 90265 RVA: 0x00334177 File Offset: 0x00332377
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTowerTrialGiveUpTempArchiveRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601609A RID: 90266 RVA: 0x00334198 File Offset: 0x00332398
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

		// Token: 0x0601609B RID: 90267 RVA: 0x003341BE File Offset: 0x003323BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601609C RID: 90268 RVA: 0x003341CB File Offset: 0x003323CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601609D RID: 90269 RVA: 0x003341D4 File Offset: 0x003323D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601609E RID: 90270 RVA: 0x003341EC File Offset: 0x003323EC
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

		// Token: 0x0601609F RID: 90271 RVA: 0x00334212 File Offset: 0x00332412
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

		// Token: 0x060160A0 RID: 90272 RVA: 0x0033422F File Offset: 0x0033242F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060160A1 RID: 90273 RVA: 0x00334238 File Offset: 0x00332438
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

		// Token: 0x04008428 RID: 33832
		private UnknownFieldSet _unknownFields;
	}
}
