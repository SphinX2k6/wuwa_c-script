using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C16 RID: 3094
	[NetMessage(EMessageId.PhantomBattleAddBuffInfoNotify)]
	public sealed class PhantomBattleAddBuffInfoNotify : IMessage<PhantomBattleAddBuffInfoNotify>, IMessage, IEquatable<PhantomBattleAddBuffInfoNotify>, IDeepCloneable<PhantomBattleAddBuffInfoNotify>, IBufferMessage
	{
		// Token: 0x06010D0C RID: 68876 RVA: 0x002772B6 File Offset: 0x002754B6
		[NullableContext(1)]
		public static PhantomBattleAddBuffInfoNotify Create()
		{
			return new PhantomBattleAddBuffInfoNotify();
		}

		// Token: 0x17003789 RID: 14217
		// (get) Token: 0x06010D0D RID: 68877 RVA: 0x002772BD File Offset: 0x002754BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700378A RID: 14218
		// (get) Token: 0x06010D0E RID: 68878 RVA: 0x002772C0 File Offset: 0x002754C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleAddBuffInfoNotify.Descriptor;
			}
		}

		// Token: 0x06010D0F RID: 68879 RVA: 0x002772C7 File Offset: 0x002754C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAddBuffInfoNotify()
		{
		}

		// Token: 0x06010D10 RID: 68880 RVA: 0x002772DA File Offset: 0x002754DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAddBuffInfoNotify(PhantomBattleAddBuffInfoNotify other) : this()
		{
			this.addBuffs_ = other.addBuffs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010D11 RID: 68881 RVA: 0x00277304 File Offset: 0x00275504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAddBuffInfoNotify Clone()
		{
			return new PhantomBattleAddBuffInfoNotify(this);
		}

		// Token: 0x1700378B RID: 14219
		// (get) Token: 0x06010D12 RID: 68882 RVA: 0x0027730C File Offset: 0x0027550C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, PhantomBattleAddBuffEffectCtx> AddBuffs
		{
			get
			{
				return this.addBuffs_;
			}
		}

		// Token: 0x06010D13 RID: 68883 RVA: 0x00277314 File Offset: 0x00275514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleAddBuffInfoNotify);
		}

		// Token: 0x06010D14 RID: 68884 RVA: 0x00277322 File Offset: 0x00275522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleAddBuffInfoNotify other)
		{
			return other != null && (other == this || (this.AddBuffs.Equals(other.AddBuffs) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010D15 RID: 68885 RVA: 0x00277358 File Offset: 0x00275558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.AddBuffs.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010D16 RID: 68886 RVA: 0x0027738C File Offset: 0x0027558C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010D17 RID: 68887 RVA: 0x00277399 File Offset: 0x00275599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010D18 RID: 68888 RVA: 0x002773A2 File Offset: 0x002755A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.addBuffs_.WriteTo(ref output, PhantomBattleAddBuffInfoNotify._map_addBuffs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010D19 RID: 68889 RVA: 0x002773CC File Offset: 0x002755CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.addBuffs_.CalculateSize(PhantomBattleAddBuffInfoNotify._map_addBuffs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010D1A RID: 68890 RVA: 0x00277405 File Offset: 0x00275605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleAddBuffInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.addBuffs_.MergeFrom(other.addBuffs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010D1B RID: 68891 RVA: 0x00277433 File Offset: 0x00275633
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010D1C RID: 68892 RVA: 0x0027743C File Offset: 0x0027563C
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.addBuffs_.AddEntriesFrom(ref input, PhantomBattleAddBuffInfoNotify._map_addBuffs_codec);
				}
			}
		}

		// Token: 0x04006B47 RID: 27463
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B48 RID: 27464
		public const int AddBuffsFieldNumber = 10;

		// Token: 0x04006B49 RID: 27465
		private static readonly MapField<int, PhantomBattleAddBuffEffectCtx>.Codec _map_addBuffs_codec = new MapField<int, PhantomBattleAddBuffEffectCtx>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<PhantomBattleAddBuffEffectCtx>(18U, PhantomBattleAddBuffEffectCtx.Parser), 82U);

		// Token: 0x04006B4A RID: 27466
		private readonly MapField<int, PhantomBattleAddBuffEffectCtx> addBuffs_ = new MapField<int, PhantomBattleAddBuffEffectCtx>();
	}
}
