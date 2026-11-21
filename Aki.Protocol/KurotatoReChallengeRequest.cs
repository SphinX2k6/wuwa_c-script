using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200089C RID: 2204
	[NetMessage(EMessageId.KurotatoReChallengeRequest)]
	public sealed class KurotatoReChallengeRequest : IMessage<KurotatoReChallengeRequest>, IMessage, IEquatable<KurotatoReChallengeRequest>, IDeepCloneable<KurotatoReChallengeRequest>, IBufferMessage
	{
		// Token: 0x0600C415 RID: 50197 RVA: 0x001D1110 File Offset: 0x001CF310
		[NullableContext(1)]
		public static KurotatoReChallengeRequest Create()
		{
			return new KurotatoReChallengeRequest();
		}

		// Token: 0x1700279D RID: 10141
		// (get) Token: 0x0600C416 RID: 50198 RVA: 0x001D1117 File Offset: 0x001CF317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700279E RID: 10142
		// (get) Token: 0x0600C417 RID: 50199 RVA: 0x001D111A File Offset: 0x001CF31A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoReChallengeRequest.Descriptor;
			}
		}

		// Token: 0x0600C418 RID: 50200 RVA: 0x001D1121 File Offset: 0x001CF321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoReChallengeRequest()
		{
		}

		// Token: 0x0600C419 RID: 50201 RVA: 0x001D1129 File Offset: 0x001CF329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoReChallengeRequest(KurotatoReChallengeRequest other) : this()
		{
			this.isFromCurWave_ = other.isFromCurWave_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C41A RID: 50202 RVA: 0x001D114E File Offset: 0x001CF34E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoReChallengeRequest Clone()
		{
			return new KurotatoReChallengeRequest(this);
		}

		// Token: 0x1700279F RID: 10143
		// (get) Token: 0x0600C41B RID: 50203 RVA: 0x001D1156 File Offset: 0x001CF356
		// (set) Token: 0x0600C41C RID: 50204 RVA: 0x001D115E File Offset: 0x001CF35E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFromCurWave
		{
			get
			{
				return this.isFromCurWave_;
			}
			set
			{
				this.isFromCurWave_ = value;
			}
		}

		// Token: 0x0600C41D RID: 50205 RVA: 0x001D1167 File Offset: 0x001CF367
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoReChallengeRequest);
		}

		// Token: 0x0600C41E RID: 50206 RVA: 0x001D1175 File Offset: 0x001CF375
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoReChallengeRequest other)
		{
			return other != null && (other == this || (this.IsFromCurWave == other.IsFromCurWave && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C41F RID: 50207 RVA: 0x001D11A4 File Offset: 0x001CF3A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsFromCurWave)
			{
				num ^= this.IsFromCurWave.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C420 RID: 50208 RVA: 0x001D11E3 File Offset: 0x001CF3E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C421 RID: 50209 RVA: 0x001D11F0 File Offset: 0x001CF3F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C422 RID: 50210 RVA: 0x001D11F9 File Offset: 0x001CF3F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsFromCurWave)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsFromCurWave);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C423 RID: 50211 RVA: 0x001D122C File Offset: 0x001CF42C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsFromCurWave)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C424 RID: 50212 RVA: 0x001D125E File Offset: 0x001CF45E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoReChallengeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsFromCurWave)
			{
				this.IsFromCurWave = other.IsFromCurWave;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C425 RID: 50213 RVA: 0x001D128F File Offset: 0x001CF48F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C426 RID: 50214 RVA: 0x001D1298 File Offset: 0x001CF498
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IsFromCurWave = input.ReadBool();
				}
			}
		}

		// Token: 0x040054F0 RID: 21744
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054F1 RID: 21745
		public const int IsFromCurWaveFieldNumber = 10;

		// Token: 0x040054F2 RID: 21746
		private bool isFromCurWave_;
	}
}
