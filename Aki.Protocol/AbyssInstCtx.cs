using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000026 RID: 38
	public sealed class AbyssInstCtx : IMessage<AbyssInstCtx>, IMessage, IEquatable<AbyssInstCtx>, IDeepCloneable<AbyssInstCtx>, IBufferMessage
	{
		// Token: 0x0600118E RID: 4494 RVA: 0x00030F6D File Offset: 0x0002F16D
		[NullableContext(1)]
		public static AbyssInstCtx Create()
		{
			return new AbyssInstCtx();
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600118F RID: 4495 RVA: 0x00030F74 File Offset: 0x0002F174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06001190 RID: 4496 RVA: 0x00030F77 File Offset: 0x0002F177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssInstCtx.Descriptor;
			}
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x00030F7E File Offset: 0x0002F17E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssInstCtx()
		{
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x00030F91 File Offset: 0x0002F191
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssInstCtx(AbyssInstCtx other) : this()
		{
			this.littleRoleMap_ = other.littleRoleMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x00030FBB File Offset: 0x0002F1BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssInstCtx Clone()
		{
			return new AbyssInstCtx(this);
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06001194 RID: 4500 RVA: 0x00030FC3 File Offset: 0x0002F1C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> LittleRoleMap
		{
			get
			{
				return this.littleRoleMap_;
			}
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x00030FCB File Offset: 0x0002F1CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssInstCtx);
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x00030FD9 File Offset: 0x0002F1D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssInstCtx other)
		{
			return other != null && (other == this || (this.LittleRoleMap.Equals(other.LittleRoleMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x0003100C File Offset: 0x0002F20C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.LittleRoleMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x00031040 File Offset: 0x0002F240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x0003104D File Offset: 0x0002F24D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x00031056 File Offset: 0x0002F256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.littleRoleMap_.WriteTo(ref output, AbyssInstCtx._map_littleRoleMap_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x00031080 File Offset: 0x0002F280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.littleRoleMap_.CalculateSize(AbyssInstCtx._map_littleRoleMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x000310B9 File Offset: 0x0002F2B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssInstCtx other)
		{
			if (other == null)
			{
				return;
			}
			this.littleRoleMap_.MergeFrom(other.littleRoleMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x000310E7 File Offset: 0x0002F2E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x000310F0 File Offset: 0x0002F2F0
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.littleRoleMap_.AddEntriesFrom(ref input, AbyssInstCtx._map_littleRoleMap_codec);
				}
			}
		}

		// Token: 0x04001F8E RID: 8078
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F8F RID: 8079
		public const int LittleRoleMapFieldNumber = 1;

		// Token: 0x04001F90 RID: 8080
		private static readonly MapField<int, int>.Codec _map_littleRoleMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 10U);

		// Token: 0x04001F91 RID: 8081
		private readonly MapField<int, int> littleRoleMap_ = new MapField<int, int>();
	}
}
