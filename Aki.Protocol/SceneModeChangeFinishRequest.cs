using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011BA RID: 4538
	[NetMessage(EMessageId.SceneModeChangeFinishRequest)]
	public sealed class SceneModeChangeFinishRequest : IMessage<SceneModeChangeFinishRequest>, IMessage, IEquatable<SceneModeChangeFinishRequest>, IDeepCloneable<SceneModeChangeFinishRequest>, IBufferMessage
	{
		// Token: 0x060183A0 RID: 99232 RVA: 0x00386A42 File Offset: 0x00384C42
		[NullableContext(1)]
		public static SceneModeChangeFinishRequest Create()
		{
			return new SceneModeChangeFinishRequest();
		}

		// Token: 0x1700519A RID: 20890
		// (get) Token: 0x060183A1 RID: 99233 RVA: 0x00386A49 File Offset: 0x00384C49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700519B RID: 20891
		// (get) Token: 0x060183A2 RID: 99234 RVA: 0x00386A4C File Offset: 0x00384C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneModeChangeFinishRequest.Descriptor;
			}
		}

		// Token: 0x060183A3 RID: 99235 RVA: 0x00386A53 File Offset: 0x00384C53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneModeChangeFinishRequest()
		{
		}

		// Token: 0x060183A4 RID: 99236 RVA: 0x00386A5B File Offset: 0x00384C5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneModeChangeFinishRequest(SceneModeChangeFinishRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060183A5 RID: 99237 RVA: 0x00386A74 File Offset: 0x00384C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneModeChangeFinishRequest Clone()
		{
			return new SceneModeChangeFinishRequest(this);
		}

		// Token: 0x060183A6 RID: 99238 RVA: 0x00386A7C File Offset: 0x00384C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneModeChangeFinishRequest);
		}

		// Token: 0x060183A7 RID: 99239 RVA: 0x00386A8A File Offset: 0x00384C8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneModeChangeFinishRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060183A8 RID: 99240 RVA: 0x00386AA8 File Offset: 0x00384CA8
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

		// Token: 0x060183A9 RID: 99241 RVA: 0x00386ACE File Offset: 0x00384CCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060183AA RID: 99242 RVA: 0x00386ADB File Offset: 0x00384CDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060183AB RID: 99243 RVA: 0x00386AE4 File Offset: 0x00384CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060183AC RID: 99244 RVA: 0x00386AFC File Offset: 0x00384CFC
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

		// Token: 0x060183AD RID: 99245 RVA: 0x00386B22 File Offset: 0x00384D22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneModeChangeFinishRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060183AE RID: 99246 RVA: 0x00386B3F File Offset: 0x00384D3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060183AF RID: 99247 RVA: 0x00386B48 File Offset: 0x00384D48
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

		// Token: 0x04009004 RID: 36868
		private UnknownFieldSet _unknownFields;
	}
}
