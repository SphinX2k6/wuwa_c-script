using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DA9 RID: 3497
	[NetMessage(EMessageId.PlayerVoiceLanguageRequest)]
	public sealed class PlayerVoiceLanguageRequest : IMessage<PlayerVoiceLanguageRequest>, IMessage, IEquatable<PlayerVoiceLanguageRequest>, IDeepCloneable<PlayerVoiceLanguageRequest>, IBufferMessage
	{
		// Token: 0x06012DD9 RID: 77273 RVA: 0x002C1108 File Offset: 0x002BF308
		[NullableContext(1)]
		public static PlayerVoiceLanguageRequest Create()
		{
			return new PlayerVoiceLanguageRequest();
		}

		// Token: 0x17003EA1 RID: 16033
		// (get) Token: 0x06012DDA RID: 77274 RVA: 0x002C110F File Offset: 0x002BF30F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EA2 RID: 16034
		// (get) Token: 0x06012DDB RID: 77275 RVA: 0x002C1112 File Offset: 0x002BF312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerVoiceLanguageRequest.Descriptor;
			}
		}

		// Token: 0x06012DDC RID: 77276 RVA: 0x002C1119 File Offset: 0x002BF319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerVoiceLanguageRequest()
		{
		}

		// Token: 0x06012DDD RID: 77277 RVA: 0x002C1121 File Offset: 0x002BF321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerVoiceLanguageRequest(PlayerVoiceLanguageRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012DDE RID: 77278 RVA: 0x002C113A File Offset: 0x002BF33A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerVoiceLanguageRequest Clone()
		{
			return new PlayerVoiceLanguageRequest(this);
		}

		// Token: 0x06012DDF RID: 77279 RVA: 0x002C1142 File Offset: 0x002BF342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerVoiceLanguageRequest);
		}

		// Token: 0x06012DE0 RID: 77280 RVA: 0x002C1150 File Offset: 0x002BF350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerVoiceLanguageRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06012DE1 RID: 77281 RVA: 0x002C1170 File Offset: 0x002BF370
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

		// Token: 0x06012DE2 RID: 77282 RVA: 0x002C1196 File Offset: 0x002BF396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012DE3 RID: 77283 RVA: 0x002C11A3 File Offset: 0x002BF3A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012DE4 RID: 77284 RVA: 0x002C11AC File Offset: 0x002BF3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012DE5 RID: 77285 RVA: 0x002C11C4 File Offset: 0x002BF3C4
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

		// Token: 0x06012DE6 RID: 77286 RVA: 0x002C11EA File Offset: 0x002BF3EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerVoiceLanguageRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012DE7 RID: 77287 RVA: 0x002C1207 File Offset: 0x002BF407
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012DE8 RID: 77288 RVA: 0x002C1210 File Offset: 0x002BF410
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

		// Token: 0x04007536 RID: 30006
		private UnknownFieldSet _unknownFields;
	}
}
