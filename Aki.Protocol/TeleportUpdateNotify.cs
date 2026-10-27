using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001343 RID: 4931
	[NetMessage(EMessageId.TeleportUpdateNotify)]
	public sealed class TeleportUpdateNotify : IMessage<TeleportUpdateNotify>, IMessage, IEquatable<TeleportUpdateNotify>, IDeepCloneable<TeleportUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601A321 RID: 107297 RVA: 0x003CE07D File Offset: 0x003CC27D
		[NullableContext(1)]
		public static TeleportUpdateNotify Create()
		{
			return new TeleportUpdateNotify();
		}

		// Token: 0x1700585A RID: 22618
		// (get) Token: 0x0601A322 RID: 107298 RVA: 0x003CE084 File Offset: 0x003CC284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700585B RID: 22619
		// (get) Token: 0x0601A323 RID: 107299 RVA: 0x003CE087 File Offset: 0x003CC287
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601A324 RID: 107300 RVA: 0x003CE08E File Offset: 0x003CC28E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportUpdateNotify()
		{
		}

		// Token: 0x0601A325 RID: 107301 RVA: 0x003CE0A1 File Offset: 0x003CC2A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportUpdateNotify(TeleportUpdateNotify other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A326 RID: 107302 RVA: 0x003CE0CB File Offset: 0x003CC2CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportUpdateNotify Clone()
		{
			return new TeleportUpdateNotify(this);
		}

		// Token: 0x1700585C RID: 22620
		// (get) Token: 0x0601A327 RID: 107303 RVA: 0x003CE0D3 File Offset: 0x003CC2D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0601A328 RID: 107304 RVA: 0x003CE0DB File Offset: 0x003CC2DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportUpdateNotify);
		}

		// Token: 0x0601A329 RID: 107305 RVA: 0x003CE0E9 File Offset: 0x003CC2E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportUpdateNotify other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A32A RID: 107306 RVA: 0x003CE11C File Offset: 0x003CC31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A32B RID: 107307 RVA: 0x003CE150 File Offset: 0x003CC350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A32C RID: 107308 RVA: 0x003CE15D File Offset: 0x003CC35D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A32D RID: 107309 RVA: 0x003CE166 File Offset: 0x003CC366
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, TeleportUpdateNotify._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A32E RID: 107310 RVA: 0x003CE190 File Offset: 0x003CC390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(TeleportUpdateNotify._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A32F RID: 107311 RVA: 0x003CE1C9 File Offset: 0x003CC3C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeleportUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A330 RID: 107312 RVA: 0x003CE1F7 File Offset: 0x003CC3F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A331 RID: 107313 RVA: 0x003CE200 File Offset: 0x003CC400
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
				if (num != 120U && num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, TeleportUpdateNotify._repeated_ids_codec);
				}
			}
		}

		// Token: 0x040098CE RID: 39118
		private UnknownFieldSet _unknownFields;

		// Token: 0x040098CF RID: 39119
		public const int IdsFieldNumber = 15;

		// Token: 0x040098D0 RID: 39120
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(122U);

		// Token: 0x040098D1 RID: 39121
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
